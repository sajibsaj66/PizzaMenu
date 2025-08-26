using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? ImgUrl { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }
    }
}
