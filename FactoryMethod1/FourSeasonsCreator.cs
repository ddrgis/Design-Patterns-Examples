namespace FactoryMethod1
{
    public class FourSeasonsCreator : PizzaCreator
    {
        public override Pizza CreatePizza()
        {
            return new FourSeasons();
        }
    }
}