namespace FactoryMethodAbstract
{
    public class ConcreteFactoryB : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}