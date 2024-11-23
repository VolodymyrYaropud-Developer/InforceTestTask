using InforceTestTask.Data.Users;

namespace InforceTestTask.Data
{
    public class URL
    {
        public int Id { get; set; }
        public string FullURL {  get; set; }

        public string ShortURL { get; set; }

        public User CreatedByUser { get; set; } 
    }
}