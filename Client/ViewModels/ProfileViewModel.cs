using AU.Shared.Models;

namespace AU.ViewModels
{
    public class ProfileViewModel
    {
        public long UserId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Email { get; set; }

        public static implicit operator ProfileViewModel(User user)
        {
            return new ProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserId = user.Id
            };
        }

    }
}