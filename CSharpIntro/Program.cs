using System;

namespace CSharpIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make bool, string, and int variables (with values)

            // change their values to something else

            // print their values with Console

            // do something in a for loop
            // do something in a while loop
            // do something with a switch statement

            // do something with if, else if, else

            // figure out how to make multi-line comments in C#
            // figure out how to format your document in VS Code

            // extra: make a new static method to do something and call it
            // extra: learn what "var" means in C# and try it out.

            bool myBool = true;
            string myString = "Here is my cool string!";
            int myInt = 13;

            myBool = false;
            myString = "Here is my cool string, but different!";
            myInt = 5;

            Console.WriteLine("----------");
            Console.WriteLine("boolean is " + myBool);
            Console.WriteLine("string is " + myString);
            Console.WriteLine("int is " + myInt);
            Console.WriteLine("----------");

            Console.WriteLine("for loop stuff :");
            for (int i = 0; i < myInt; i++)
            {
                Console.WriteLine(i + " :) ");
            }

            Console.WriteLine("----------");

            Console.WriteLine("while loop stuff :");

            // counter for while loop
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine("I will print 5 times");
                x += 1;

            }
            Console.WriteLine("----------");

            Console.WriteLine("switch statement stuff :");

            //switch 
            int switch_on = 3;
            switch (switch_on)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.WriteLine("----------");

            Console.WriteLine("if statement stuff :");
            // if check statement int
            x = 3;

            if (x == 1)
            {
                Console.WriteLine("x is 1");
            }
            else if (x == 2)
            {
                Console.WriteLine("x is 2");
            }
            else if (x == 3)
            {
                Console.WriteLine("x is 3");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }

            /* I am a multi line comment
            Here is my other line
            and here is my last line

            ALT SHIFT F will auto format your code

             */

            Console.WriteLine("----------");

            Console.WriteLine("static method stuff :");
            Program.myStaticMethod();

            Console.WriteLine("----------");

            Console.WriteLine("var stuff :");

            var myVarBoolean = true;
            var myVarInt = 7;
            var myVarString = "I'm a string variable setup with var.";

            Console.WriteLine("myVarBoolean is a " + myVarBoolean.GetType());
            Console.WriteLine("myVarInt is a " + myVarInt.GetType());
            Console.WriteLine("myVarString is a " + myVarString.GetType());
        }

        public static void myStaticMethod () {
            Console.WriteLine("Hello from myStaticMethod!");
        }

    }
}
