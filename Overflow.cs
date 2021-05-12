using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    public class TestStackOverflowDetection
    {
        [TestMethod]
        public void TestDetectStackOverflow()
        {
            try
            {
                InfiniteRecursion();
            }
            catch (StackOverflowException e)
            {
                Debug.WriteLine(e);
            }
        }

        private static int InfiniteRecursion()
        {
            // Insert the following call in all methods that
            // we suspect could be part of an infinite recursion 
            CheckForStackOverflow();

            // Force an infinite recursion
            return InfiniteRecursion();
        }

        private static void CheckForStackOverflow()
        {
            StackTrace stack = new StackTrace(true);
            if (stack.FrameCount > 10) // Set stack limit to 1,000 calls
            {
                // Output last 10 frames in the stack
                //foreach (var f in stack.GetFrames().Reverse().Take(30).Reverse())
                  //  Debug.Write("\tat " + f);

                // Throw a stack overflow exception
                throw new StackOverflowException();
            }
        }
    }
        class Program
    {
        
      static void Main(string[] args)
        {
            TestStackOverflowDetection abc = new TestStackOverflowDetection();
            abc.TestDetectStackOverflow();
            Console.ReadLine();
            
        }

    }
}
