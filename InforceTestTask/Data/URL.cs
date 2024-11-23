namespace InforceTestTask.Data
{
    public class URL
    {
        public int Id { get; set; }
        public string FullURL { get; set; }
        public string ShortURL { get; set; }

        public int CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
    }

}