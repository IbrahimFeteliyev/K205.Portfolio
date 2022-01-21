namespace K205.Portfolio.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int  Year { get; set; }      
        public string Description { get; set; }
        public string PhotoURL { get; set; }    
    }
}
