using System.ComponentModel.DataAnnotations;

namespace PizzasWebApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [Range(1, 300)]
        public double Price { get; set; }
        public string PictureUrl { get; set;}


        public Pizza() { }

        public Pizza(int id, string name, string description, double price, string pictureUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            PictureUrl = pictureUrl;
        }
    }
}
