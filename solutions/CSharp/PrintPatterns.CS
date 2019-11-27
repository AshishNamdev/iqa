/*
Created on Nov 25, 2019

@author: Ashish Namdev
*/

/*
## Q4 Programming
### Print following patterns
*/

using System;

namespace iqa
{
    class PrintPatterns
    {
        int n = 5;

        /**
        half pyramid
        1
        2 2
        3 3 3
        4 4 4 4
        5 5 5 5 5
        */
        public void halfPyramid()
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                   Console.Write($"{i} ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Inverted half pyramid
        5 5 5 5 5
        4 4 4 4
        3 3 3
        2 2
        1
        */

        public void invertedHalfPyramid()
        {
            for(int i = n; i >= 1; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                   Console.Write(String.Format("{0,2}", i));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Triangle
            1
           2 2
          3 3 3
         4 4 4 4
        5 5 5 5 5
        */
        public void triangle()
        {
            for(int i = 1; i <= n; i++)
            {
                for(int k = n; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <=i; j++)
                {
                   Console.Write(String.Format("{0,2}", i));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Full pyramid
                1
              2 2 2
            3 3 3 3 3
          4 4 4 4 4 4 4
        5 5 5 5 5 5 5 5 5
        */
        public void fullPyramid()
        {
            for(int i = 1; i <= n; i++)
            {
                for(int k = 1; k <= (n - i); k++)
                {
                    Console.Write("  ");
                }
                for(int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(String.Format("{0,2}", i));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Inverted full pyramid

        5 5 5 5 5 5 5 5 5
          4 4 4 4 4 4 4
           3 3 3 3 3
            2 2 2
              1
        */
        public void invertedFullPyramid()
        {
            for(int i = n; i >= 1; i--)
            {
                for(int k = 1; k <= (n - i); k++)
                {
                    Console.Write("  ");
                }
                for(int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(String.Format("{0,2}", i));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Pascal's triangle
                  1
                1   1
              1   2   1
            1   3   3    1
          1  4    6   4   1
        1  5   10   10  5   1 
        */
        public void pascalsTriangle()
        {
            int val = 1;
            for(int i = 0; i <= n; i++)
            {
                for(int k = 1; k <= (n - i); k++)
                {
                    Console.Write("  ");
                }
                for(int j = 0; j < i + 1; j++)
                {
                    val = (i == 0 || j == 0) ? 1 : (val * (i - j + 1) / j);
                    Console.Write(String.Format("{0,4}", val));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        /*
        Floyd's Triangle
        1 
        2 3 
        4 5 6 
        7 8 9 10 
        */
        public void floydsTriangle()
        {
            int no = 1;
            for(int i = 1; i < n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                   Console.Write(String.Format("{0,3}", no++));
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}