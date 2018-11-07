using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApps
{
    // Declare Delegate 
    public delegate int Calculator(int a , int b);
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            // call add method through delegate object reference
            Calculator calAdd = new Calculator(Add);
            var sum = calAdd(2, 4);
            Console.WriteLine("Sum of a and b is:" +sum);

            // call Sub method through delegate object reference
            Calculator calSub = new Calculator(Sub);
            var sub = calSub(2, 4);
            Console.WriteLine("Subtract of a and b is:" + sub);
           
            // call Mul method through delegate object reference
            Calculator calMul = new Calculator(Mul);
            var mul = calMul(2, 4);
            Console.WriteLine("Subtract of a and b is:" + mul);

            // call Div method through delegate object reference
            Calculator calDiv = new Calculator(Div);
            var div = calDiv(2, 4);
            Console.WriteLine("Division of a and b is:" + div);

            // Pass delegate as a Parameter 
            Modules(Add , 1, 2);
            Modules(Mul , 1, 2);
            Modules(Div, 1, 2);
            Modules(Div, 1, 2);
            */

            // Multi Delegate ............ call method simultaneously  
            Calculator cal = Add;
            cal += Sub;
            cal += Div;
            cal += Mul;
            // invoke delegate or call
            Console.WriteLine(cal(1, 2));
            // alternative technique
            //cal.Invoke(1, 2);
            Console.WriteLine("Hello Delegate World!");
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            Console.WriteLine("Add:" + a + b);
            return a + b;
        }
        static int Mul(int a, int b)
        {
            Console.WriteLine("Mul:" + a * b);
            return a * b;
        }
        static int Sub(int a, int b)
        {
            Console.WriteLine("Sub:" + (a - b));
            return  a - b;
        }
        static int Div(int a, int b)
        {
            Console.WriteLine("Div:" + a / b);
            return a / b;
        }

        //Pass Delegate as a parameter 
        static void Modules( Calculator cal , int a , int b)
        {
            // delegate invoke method here
            cal(a, b);
        }
    }
}
