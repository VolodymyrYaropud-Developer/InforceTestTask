namespace InforceTestTask.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<URL> Uries { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        User = 1,
        Admin = 2
    }
}
