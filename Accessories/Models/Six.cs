namespace Accessories.Models
{
    public class Six
    {
       public string Name { get; set; }
        public int Category_Id { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string About { get; set; }
        public string Attributes { get; set; }
        public Six(string name, int category_Id, string category, int price, string about, string attributes)
        {
            Name = name;
            Category_Id = category_Id;
            Category = category;
            Price = price;
            About = about;
            Attributes = attributes;
            

        }
    }
}
