using System.Collections;
using System.Collections.Generic;
using System;

namespace Polymorphism
{
    class Operation
    {
        public virtual int PerformOperation(int a, int b)
        {
            return 0;
        }
    }

    class Addition : Operation
    {
        public override int PerformOperation(int a, int b)
        {
            return a + b;
        }
    }

    class Subtraction : Operation
    {
        public override int PerformOperation(int a, int b)
        {
            return a - b;
        }
    }

    class Calculator
    {
        public void calculate()
        {
            Operation[] operations = new Operation[2];

            operations[0] = new Addition();
            operations[1] = new Subtraction();

            if (operations[0] is Addition)
            {
                Addition addition = operations[0] as Addition;
                addition.PerformOperation(2, 3);
            }
            if (operations[1] is Subtraction)
            {
                Subtraction subtraction = (Subtraction)operations[1];
                subtraction.PerformOperation(2, 3);
            }
        }     
    }
}