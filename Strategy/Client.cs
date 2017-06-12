namespace Strategy
{
    //Client may not have a strategy field but have a method with IStrategy attribute
    public class Client
    {
        private readonly IStrategy strategy;

        public Client(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Operation();
        }
    }
}