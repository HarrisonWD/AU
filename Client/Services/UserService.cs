using AU.Shared;
using System.Net.Http.Json;

namespace AU.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<UserViewModel>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<UserViewModel>>("api/user");
        }
    }
}
