namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }

        public Pizza()
        {

        }
        public Pizza(string name, string description, string img, double price)
        {
            Name = name;
            Description = description;
            Img = img;
            Price = price;
        }
    }
}
