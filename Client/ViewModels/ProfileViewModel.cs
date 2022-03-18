using AU.Shared.Models;

namespace AU.ViewModels
{
    public class ProfileViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public static implicit operator ProfileViewModel(User user)
        {
            return new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Id = user.Id
            };
        }

    }
}