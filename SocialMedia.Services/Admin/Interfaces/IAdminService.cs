namespace SocialMedia.Services.Admin.Interfaces
{
    using SocialMedia.Services.Admin.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IAdminService
    {
        Task<IEnumerable<AdminUserListingModel>> All();

        DeleteUserViewModel GetUserDelete(string userId);

        void DeleteUser(string userId);

        EditUserViewModel GetUserEdit(string userId);

        void EditUser(EditUserViewModel model);

        void CreateUser(CreateUserViewModel model);
    }
}
