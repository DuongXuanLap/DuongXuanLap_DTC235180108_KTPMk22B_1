namespace DuongXuanLap_DTC235180108_KTPMk22B_1.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        //Navigation property to Category

        public Category? Category { get; set; }
    }
}
