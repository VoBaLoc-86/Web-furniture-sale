namespace FurnitureWeb.Models
{
    public class Product:BaseModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; } = null;
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
