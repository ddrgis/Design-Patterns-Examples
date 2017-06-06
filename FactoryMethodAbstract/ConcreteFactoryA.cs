namespace FactoryMethodAbstract
{
    public class ConcreteFactoryA : ProductFactory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}