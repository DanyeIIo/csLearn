using Models.Showcase;

namespace Models.Items
{
    public class Item : IShowcaseItem, IEntity
    {
        public int Identifier { get; set; } // IItem
        public string Name { get; set; } // IItem
        public int Volume { get; set; } // IItem
        public Item(int identifier, string name, int volume)
        {
            Identifier = identifier;
            Name = name;
            Volume = volume;
        }
        public Item()
        {
        }
        public IResult Validate() // IEntity
        {
            IResult result = new Result(true);
            if (Volume <= 0)
            {
                result.Check = false;
                result.Message += "Volume can not be less and equal to 0";
            }
            if (string.IsNullOrWhiteSpace(Name))
            {
                result.Check = false;
                result.Message += "\nName can not be empty ";
            }
            else if (Name.IsSpace())
            {
                result.Check = false;
                result.Message += "\nName can not contains whiite spaces";
            }
            return result;
        }
    }
}
