using System.ComponentModel.DataAnnotations;
namespace Day_2Week2.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Product price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Product price must be greater than 0.")]
    public decimal Price { get; set; }
}

