namespace LibraryManagementSystem.Models.CrudModels
{
    public class AddBooks
    {
        public required string Title { get; set; }
        public string? Edition { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
