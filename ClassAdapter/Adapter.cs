﻿namespace ClassAdapter
{
    public class Adapter : Adaptee, ITarget
    {
        public void Operation()
        {
            SpecificOperation();
        }
    }
}