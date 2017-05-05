namespace FactoryMethod1
{
    public class PepperoniCreator : PizzaCreator
    {
        public override Pizza CreatePizza()
        {
            return new Pepperoni();
        }
    }
}