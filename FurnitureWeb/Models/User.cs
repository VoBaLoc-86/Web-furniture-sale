namespace FurnitureWeb.Models
{
    public class User:BaseModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public required string Password { get; set; }
    }
}
