using System;

namespace thedelegate.BlogDotNet
{
    public class Comment : IContentProvider
    {
        public string Content { get; set; }
        public string FullName { get; set; }
        public DateTime? Date { get; set; }
        public string Homepage { get; set; }
        public string Email { get; set; }
        public bool IsSpam { get; set; }
    }
}