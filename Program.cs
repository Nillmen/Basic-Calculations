using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace basic_cal
{

    class Program
    {
        static void Main()
        {

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(SumBignums(a,b));
        }

        static string SumBignums(string a, string b)
        {
            // Reverse the strings of 2 numbers
            a = new string(a.Reverse().ToArray());
            b = new string(b.Reverse().ToArray());


            a = a + "0";
            b = b + "0";

            if (a.Length < b.Length)
            {
                for (int i = a.Length; i < b.Length; i++)
                {
                    a = a + "0";

                }

            }
            if (b.Length < a.Length)
            {
                for (int i = b.Length; i < a.Length; i++)
                {
                    b = b + "0";
                }
            }

            int[,] arr = new int[3, 100];

            for (int i = 0; i < a.Length; i++)
            {
                arr[0,i] = a[i] - 48;
            }

            for (int i = 0; i < b.Length; i++)
            {
                arr[1,i] = b[i] - 48;
            }

            int nho = 0;
            int tong;

            for (int i = 0; i < a.Length; i++)
            {
                tong = arr[0,i] + arr[1,i] + nho;
                if (tong < 10)
                {
                    arr[2,i] = tong;
                    nho = 0;
                }
                else
                {
                    arr[2,i] = tong % 10;
                    nho = tong / 10;
                }
            }
          
            string sum = arr[2,0].ToString();
            string x;
            for (int i = 1; i < a.Length; i++)
            {
                x = arr[2, i].ToString();         
                sum = sum + x;

            }

            while (sum[sum.Length - 1] == '0')
{
    			sum = sum.Remove(sum.Length-1, 1);

}


            sum = new string(sum.Reverse().ToArray());
            return sum;
        }

        

      
    }
}