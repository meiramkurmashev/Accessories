namespace Accessories.Models
{
    public class Three
    {
        public int Id { get; }
        public string Name { get; }

        public int Category_Id { get; }



        public Three(int id, string name, int category_Id)
        {
            Id = id;
            Name = name;
            Category_Id = category_Id;


        }
    }
}