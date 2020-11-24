using System;

namespace MyApplication
{
    class Program
    {
        //Simple method
        static void MyMethod()      //Method name. Static - belongs to program sclass and not an object of the program class.
        {
            Console.WriteLine("I just got executed!");      //Functions executed when method is called
        }

        //Method with parameters
        static void MyMethodArgs(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        //Method with default value for parameter
        static void MyMethodDef(string country = "Norway - default value")      //Default value for method. It returs to call when no argument provided
        {
            Console.WriteLine(country);
        }

        //Method with multiple parameters. U can add as much parameters as u want.
        static void MyMethodMultiParam(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        //Method with return value
        static int MyMethodReturnsValue(int x, int y)
        {
            return x + y;
        }

        //Method with key: value syntax
        static void MyMethodNames(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3 + " not " + child2 + " not " + child1);
        }


        static void Main(string[] args)     //Method call performs some functions
        {
            MyMethod();
            MyMethodArgs("Peter");      //Cannot be executed without argument
            MyMethodDef();
            MyMethodDef("India");
            MyMethodMultiParam("Peter", 26);

            Console.WriteLine(MyMethodReturnsValue(3, 1361));       //Value desc
            int z = MyMethodReturnsValue(3, 1361);
            Console.WriteLine(z);

            MyMethodNames(child1: "chiled1", child3: "child3", child2: "child2");
        }
    }
}