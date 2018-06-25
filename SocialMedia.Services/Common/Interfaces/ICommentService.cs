namespace SocialMedia.Services.Common.Interfaces
{
    public interface ICommentService
    {
        void CreateComment(int pictureId, string commentContent, string name);

        void DeleteComment(int commentId);
    }
}
