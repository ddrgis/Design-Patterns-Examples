namespace Bridge
{
    public abstract class Abstraction
    {
        private readonly Implementation implementation;

        protected Abstraction(Implementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual void Operation()
        {
            implementation.ImplementationMethod();
        }
    }
}