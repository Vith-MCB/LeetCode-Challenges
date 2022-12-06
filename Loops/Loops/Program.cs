/*
 * Loops
 * 
 * FOR LOOP:
 * 
 * for(variable; in range ; do){}
 * 
 * ex:
 * 
 * for(int i = 0; i < example; i++){}
 * 
 * 
 * WHILE LOOP: Checks the result every time that it loops and checks the condition first
 * 
 * while(condition){}
 * 
 * ex:
 * 
 * while(true){}
 * 
 * 
 * 
 * DO WHILE LOOP: Checks the result every time that it loops, but runs the code and then checks the condition
 * 
 * do
 * {
 * }
 * while(condition)
 * 
 * ex:
 * 
 * do{ count++; } while(count < 10);
 * 
 * 
 */


/*
 * LOOPS CHALLENGE 1


using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void ForLoop()
        {
            for(int i = -3; i <= 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = -3;
            while(i <= 3)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public static void Main(string[] args)
        {
            WhileLoop();
            ForLoop();

        }

    }
}

 */

/*
 * LOOPS CHALLENGE 1
 * 
 * skip divisible by three values
 * 


using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            int i = -10;

            while (true)
            {

                if (i % 3 != 0) {
                    Console.WriteLine(i++);
                } 
                else
                {
                    i++;
                }

                if (i == 10) { break; }
            }
        }
    }
}

 */
