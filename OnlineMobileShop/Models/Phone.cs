namespace OnlineMobileShop.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
    }
}
