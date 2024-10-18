using System.ComponentModel.DataAnnotations;
namespace BlazorServerApp.Data
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please fill name")]
        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public int IsDeleted { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
