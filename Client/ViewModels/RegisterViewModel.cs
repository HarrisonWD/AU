using System.Net.Http.Json;
using AU.Shared.Models;

namespace AU.ViewModels
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ReenterPassword { get; set; }

        private HttpClient _httpClient;

        public RegisterViewModel()
        {

        }

        public RegisterViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RegisterUser()
        {
            Console.WriteLine(this.Email);
            Console.WriteLine(this.Password);
            await _httpClient.PostAsJsonAsync<User>("user/registeruser", this);
        }

        public static implicit operator RegisterViewModel(User user)
        {
            return new RegisterViewModel
            {
                Email = user.Email,
                Password = user.Password
            };
        }

        public static implicit operator User(RegisterViewModel registerViewModel)
        {
            return new User
            {
                Email = registerViewModel.Email,
                Password = registerViewModel.Password
            };
        }


    }
}
