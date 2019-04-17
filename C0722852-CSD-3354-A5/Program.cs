using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722852_CSD_3354_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateList a = new GenerateList();
            a.Run(57);
        }
        class GenerateList
        {
            const int LEN = 100;

            ArrayList ListQ;
            public void Run(int AddUpToNumber)
            {
                Random r = new Random();

                ListQ = new ArrayList();
                for (int i = 0; i < LEN; i++)
                {
                    ListQ.Add(r.Next(100));
                    this.findTwoNumbersThatAddUpto(AddUpToNumber);
                    break;
                }
            }

            public void findTwoNumbersThatAddUpto(int a)
            {
                Random r = new Random();
                int n1 = 0;
                int n2 = 0;
                for (int i = 0; i < LEN; i++)
                {
                    int num1 = ListQ.Add(r.Next(100));
                    int num2 = ListQ.Add(r.Next(100));
                    if (num1 + num2 == a)
                    {
                        n1 = num1;
                        n2 = num2;
                        Console.WriteLine($"The Two Numbers are the Folowing {n1} and {n2}.");
                    }
                }
            }
        }
    }
}

