using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF006_JQ8Z8Z
{
    internal class PMPHF006_JQ8Z8Z
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().Replace(",", "").ToCharArray();
            int steps = 0;
            int count = 0;
            int zeros = 0;
            for(int i =  0; i < numbers.Length; i++)
            {
                if (numbers[i] == '1') count++;
            }

            for(int i = numbers.Length-1; i > numbers.Length-1-count; i--)
            {
                if (numbers[i] == '0')
                {
                    zeros++;
                }
            }

            int j = 0;
            while(steps != zeros)
            {
                if (numbers[j]=='1')
                {
                    int k = numbers.Length-1;
                    while (numbers[k] != '0')
                    {
                        k--;
                    }
                    char temp = numbers[j];
                    numbers[j] = numbers[k];
                    numbers[k] = temp;
                    steps++;
                }
                j++;
            }
            Console.WriteLine(steps);
            Console.ReadLine();
        }
    }
}
