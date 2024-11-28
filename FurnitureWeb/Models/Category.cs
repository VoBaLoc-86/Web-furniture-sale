namespace FurnitureWeb.Models
{
    public class Category:BaseModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
