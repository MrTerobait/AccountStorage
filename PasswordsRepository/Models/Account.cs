namespace AccountStorage.Models
{
    public class Account
    {
        public string Description { get; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
        public string PasswordCreationDate { get; private set; }
    }
}
