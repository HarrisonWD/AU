using System.Security.Cryptography;
using System.Text;


namespace AU.Server


{
    public class Utility
    {
        public static string Encrypt(string password)
        {
            var provider = MD5.Create();
            string salt = "S0m3R4nD0mS4lt";
            byte[] bytes = provider.ComputeHash(Encoding.UTF32.GetBytes(salt + password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}
