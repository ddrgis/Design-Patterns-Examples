namespace Facade
{
    public class Facede
    {
        private readonly SubSystem1 subSystem1 = new SubSystem1();
        private readonly SubSystem2 subSystem2 = new SubSystem2();
        private readonly SubSystem3 subSystem3 = new SubSystem3();

        public void MethodA()
        {
            subSystem1.Operation1();
            subSystem3.Operation3();
        }

        public void MethodB()
        {
            subSystem2.Operation2();
            subSystem1.Operation1();
        }
    }
}