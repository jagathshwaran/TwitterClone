using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DataLayer.ViewModel
{
    public class TweetViewModel
    {
        public TweetMessageViewModel TweetMessageViewModel { get; set; }
        public List<TweetMessageViewModel> TweetsViewModel { get; set; }
        public Tweetdetails Tweetdetails { get; set; }

    }

    public class TweetMessageViewModel
    {
        public int TweetId { get; set; } = 0;

        [Required(ErrorMessage = "Tweet Required")]
        [MaxLength(140, ErrorMessage = "Tweet message max length is 140 charaters")]
        public string TweetMessage { get; set; }

        public string userid { get; set; }

        public DateTime Created { get; set; }

        public bool isUserTweet { get; set; }
    }

    public class Tweetdetails
    {
        public int TotalTweets { get; set; } = 0;

        public int TotalFollowing { get; set; } = 0;

        public int TotalFollowers { get; set; } = 0;

    }
}
