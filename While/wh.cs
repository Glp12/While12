using System;

namespace While
{
    public class wh
    {
        public bool While4(int a)
        {

            return false;
        }
        public int While8(int a)
        {
            int k=1;
            if (a <= 0)
            {
                return 0;
            }
            while (k * k <= a)
            {
                k++;
            }
            return k;
        }
        public int While12(int a)
        {
            int k = 1;
            int sum=k;
            if (a <= 1)
            {
                return 0;
            }
            for (int i = k; i > 0; i--)
            {
                sum += i;
            }
            while (sum < a)
            {
                for(int i=k;i>0; i--)
                {
                    sum += i;
                }
                k++;
            }
            return k;
        }
        public int While16(int p)
        {
            int t = 0;
            double k = 10;
            double sum = 0;
            double copy = sum;
            if (p<0 && p > 50)
            {
                return 0;
            }
            while (sum <= 200)
            {
                sum += k;
                k = k + ((k * p) / 100);
                t++;
            }
            return t;
        }
        public bool While20(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            while (n>0)
            {
                if (n%10==2)
                {
                    return true;
                }
                else
                {
                    n = n / 10;
                }
            }
            return false;
        }
        public bool While24(int n)
        {
            int a=1,b = 1,c=0,d=0;
            if (n <= 1)
            {
                return false;
            }
            while (n>0)
            {
                n -= a;
                d = a;
                c = b;
                a = a + b;
                b = d;
            }
            if (n == 0)
            {
                return true;
            }
            return false;
        }
    }
}
