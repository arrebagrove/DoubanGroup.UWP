﻿using DoubanGroup.Core.Api;
using DoubanGroup.Core.Api.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanGroup.Client.ViewModels
{
    public class ChannelDetailViewModel : ViewModelBase
    {
        private Channel _channel;

        public Channel Channel
        {
            get { return _channel; }
            set { this.SetProperty(ref _channel, value); }
        }

        private const int QUERY_COUNT = 20;

        public ObservableCollection<Group> GroupList { get; private set; }

        public ObservableCollection<ChannelTopic> TopicList { get; private set; }

        private ApiClient ApiClient { get; set; }        

        public ChannelDetailViewModel(ApiClient apiClient)
        {
            this.ApiClient = apiClient;
            this.GroupList = new ObservableCollection<Group>();
            this.TopicList = new ObservableCollection<ChannelTopic>();
        }

        public void Init(Channel channel)
        {
            this.Channel = channel;

            this.InitGroups();

            this.LoadTopics();
        }

        private async Task InitGroups()
        {
            var groupList = await this.ApiClient.GetGroupByChannel(this.Channel.Name);

            foreach (var group in groupList.Items)
            {
                this.GroupList.Add(group);
            }
        }

        private async Task LoadTopics()
        {
            if (this.IsLoading)
            {
                return;
            }

            try
            {
                this.IsLoading = true;

                var start = this.TopicList.Count;

                var topicList = await this.ApiClient.GetTopicByChannel(this.Channel.Name, start, QUERY_COUNT);

                foreach (var topic in topicList.Topics)
                {
                    this.TopicList.Add(topic);
                }
            }
            finally
            {
                this.IsLoading = false;
            }
        }
    }
}