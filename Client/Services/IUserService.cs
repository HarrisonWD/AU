using AU.Shared;
using System.Collections.Generic;

namespace AU.Client.Services
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetUsers();
    }
}
