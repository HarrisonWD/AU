using AU.Shared.Models;
using System.Net.Http.Json;

namespace AU.ViewModels
{
    public class ProfileViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        private HttpClient _httpClient;

        public ProfileViewModel()
        {

        }

        public ProfileViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task UpdateProfile()
        {
            User user = this;
            await _httpClient.PutAsJsonAsync("user/updateprofile/1", user);
            this.Message = "Updated profile details";
        }

        public async Task GetProfile()
        {
            User user = await _httpClient.GetFromJsonAsync<User>("user/getprofile/1");
            LoadCurrentObject(user);
            this.Message = "Obtained details";
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            this.FirstName = profileViewModel.FirstName;
            this.LastName = profileViewModel.LastName;
            this.Email = profileViewModel.Email;
            //add more fields
        }


        public static implicit operator User(ProfileViewModel profileViewModel)
        {
            return new User
            {
                FirstName = profileViewModel.FirstName,
                LastName = profileViewModel.LastName,
                Email = profileViewModel.Email,
                Id = profileViewModel.Id
            };
        }

        public static implicit operator ProfileViewModel(User user)
        {
            return new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Id = user.Id,
            };
        }

    }
}