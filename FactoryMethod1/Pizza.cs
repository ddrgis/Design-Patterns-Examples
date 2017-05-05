namespace FactoryMethod1
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual string GetFullDescription()
        {
            return $"{Name} Pizza, Price = {Price}";
        }

        public override string ToString()
        {
            return GetFullDescription();
        }
    }
}