using System;
using System.Collections.Generic;

namespace thedelegate.BlogDotNet
{
    public class PageEntry
    {
        public string Slug { get; set; }
        public PageState State { get; set; }
        public string Author { get; set; }
        public DateTime? PublishDate { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Page Page { get; set; }
        public bool CommentsClosed { get; set; }
    }
}