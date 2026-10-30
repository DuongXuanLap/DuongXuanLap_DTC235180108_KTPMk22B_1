using System.ComponentModel.DataAnnotations;

namespace DuongXuanLap_DTC235180108_KTPMk22B_1.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]

        [StringLength(100, ErrorMessage = "Tên danh mục phải từ 2 đến 100 ký tự")]
        public string Name { get; set; }= string.Empty;

        public List<Product>? Products { get; set; } 
    }
}
