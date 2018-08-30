namespace SocialMedia.Services.Common.Models
{
    using System.Collections.Generic;

    public class CommentsAndSection
    {
        public IEnumerable<CommentIndex> Comments { get; set; }

        public int SectionNumber { get; set; }

        public bool IsHomePage { get; set; } = false;
    }
}
