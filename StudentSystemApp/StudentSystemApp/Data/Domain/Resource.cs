namespace StudentSystemApp.Data.Domain
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string AuthorId { get; set; } = null!;
        public string AuthorName { get; set; } = null!;
        public string AuthorDescription { get; set; } = null!;
        public string AuthorAuthor { get; set; } = null!;


    }
}
