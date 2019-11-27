/*
Created on Nov 20, 2019

@author: Ashish Namdev
*/

/*
## Q4-Programming
### Print following patterns
*/

public class PrintPatterns
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
                System.out.printf("%2d", i);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.printf("%2d", i);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.print(" ");
            }
            for(int j = 1; j <=i; j++)
            {
                System.out.printf("%2d", i);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.print("  ");
            }
            for(int j = 1; j <= (2 * i - 1); j++)
            {
                System.out.printf("%2d", i);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.print("  ");
            }
            for(int j = 1; j <= (2 * i - 1); j++)
            {
                System.out.printf("%2d", i);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.print("  ");
            }
            for(int j = 0; j < i + 1; j++)
            {
                val = (i == 0 || j == 0) ? 1 : (val * (i - j + 1) / j);
                System.out.printf("%4d", val);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
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
                System.out.printf("%d ", no++);
            }
            System.out.print("\n");
        }
        System.out.print("\n");
    }

    public static void main(final String []args)
    {
        PrintPatterns printPatterns = new PrintPatterns();

        printPatterns.halfPyramid();
        printPatterns.invertedHalfPyramid();
        printPatterns.triangle();
        printPatterns.fullPyramid();
        printPatterns.invertedFullPyramid();
        printPatterns.pascalsTriangle();
        printPatterns.floydsTriangle();
    }
}