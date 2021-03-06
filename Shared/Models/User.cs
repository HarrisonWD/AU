namespace AU.Shared.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int DarkTheme { get; set; }
        public int Notifications { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateCreated { get; set; }= DateTime.Now;

        public string Role { get; set; } = "Customer";
    }
}
