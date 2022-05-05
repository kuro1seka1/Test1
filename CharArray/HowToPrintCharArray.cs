
using System;
using System.IO;

class ArrayClass2D
{
    const int MAX = 100;

    static void Print2DArray(int m, int n, char [] arr,int [,] a)
    {
         
        /*  k - starting row index
        m - ending row index
        l - starting column index
        n - ending column index */
        int count  = 0;
        int k = 0, l = 0;
        while (k < m && l < n) {
            /* Print the first row from the remaining
          rows */
            for (int i = l; i < n; ++i) {
                a[k,i] = arr [count++];
            }
            k++;
            /* Print the last column from the remaining
          columns */
            for (int i = k; i < m; ++i) {
                a[i,n - 1] = arr [count++];
            }
            n--;
            /* Print the last row from the remaining
           rows */
            if (k < m) {
                for (int i = n - 1; i >= l; --i) {
                    a[m - 1,i] = arr [count++];
                }
                m--;
            }
            /* Print the first column from the remaining
           columns */
            if (l < n) {
                for (int i = m - 1; i >= k; --i) {
                    a[i,l] = arr [count++];
                }
                l++;
            }
            
        }
    }
        static void Main()
        {   
            char [] arr = new char ['a'];
            
            char C = 'n';
            int m = 4, n = 5;
            // Pass the array as an argument.
            int [,] a = new int [MAX,MAX];
            Print2DArray(5,4,new char[C],a );
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write( "{0,3}",a[i,j]);
                }
                Console.Write("\n");

        }
    }
}