using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Operation
    {
        double op1;
        double op2;

        public Operation()
        {
            op1 = 0;
            op2 = 0;
        }

        public void setOp1(double x)
        {
            op1 = x;
        }

        public void setOp2(double x)
        {
            op2 = x;
        }

        public double getOp1()
        {
            return op1;
        }

        public double getOp2()
        {
            return op2;
        }

        public double plus()
        {
            return op1 + op2;
        }

        public double moins()
        {
            return op1 - op2;
        }

        public double divise()
        {
            return op1 / op2;
        }

        public double multiplie()
        {
            return op1 * op2;
        }
    }
}
