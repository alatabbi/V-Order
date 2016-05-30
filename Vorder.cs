using System;
using System.Collections.Generic;
using System.Text;

namespace VORDER
{
    public static class Vorder
    {
        public static int Compare(string x, string y)
       {    
            int i = 0;
            int j = 0;
            int m = x.Length;
            int n = y.Length;
            while (i < m && j < n && x[i] == y[j])
            {
                i++;
                j++;
            }

            if (i == m)
            {
                if (m == n)
                    return 0;
                else
                    return -1;    
            }

            if (j == n)
            {
                if (m == n)
                    return 0;
                else
                    return 1;  
            }
            while (true)
            {
                while (j < n && x[i] > y[j])
                {
                    j++;
                }
                if (j == n)
                    return 1;  
                i++;
                while (i < m && x[i] < y[j])
                {
                    i++;
                }

                if (i == m)
                    return -1; 
                j++;
            }
            
        }
        public static int CompareSimple (string x, string y)
        {
            
            int m = x.Length;
            int n = y.Length;
            int i = 0;
            int j = 0;
            int d = 0; 
            while (i < m && j < n)
            {
                if (x[i] < y[j])
                {
                    i++;
                    d = -1; 
                }
                else if (x[i] > y[j])
                {
                    j++;
                    d = 1; 
                }
                else
                {
                    if (d > 0)
                    {
                        d = -1; i++;
                    }
                    else if (d < 0)
                    {
                       d = 1; j++;
                    }
                    else
                    {
                        i++; j++;
                    }        
                }
            }
            if (d == 0)
            {
                if (m < n)
                {
                    d = 1;
                }
                else if (n < m)
                {
                    d = -1;
                }
            } 
            return d;
        }
    }
}
