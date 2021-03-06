﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubanGroup.Core.Api.Entity
{
    public class Photo
    {
        [JsonProperty("album_id")]
        public long AlbumID { get; set; }

        [JsonProperty("album_title")]
        public string AlbumTitle { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public long ID { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("liked_count")]
        public int LikedCount { get; set; }

        [JsonProperty("next_photo")]
        public long NextPhoto { get; set; }

        [JsonProperty("prev_photo")]
        public long PreviousPhoto { get; set; }

        [JsonProperty("recs_count")]
        public int RecommandsCount { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("sizes")]
        public PhotoSizes Sizes { get; set; }
    }
}
