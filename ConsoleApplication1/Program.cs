using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int salaryAmount;

            while (true)
            {
                salaryAmount = ReadInt("Ange antalet löner: ");
                if (salaryAmount > 1)
                {
                    ProcessSalaries(salaryAmount);
                }

                break;
            }
        }

        
        static void ProcessSalaries(int count)
        {
            int[] salaryValue = new int[count];
            int[] salaryValueLength = new int[count];

            for (int i = 0; i < count; i++)
            {
                salaryValue[i] = ReadInt(String.Format("Ange lön nummer {0}: ", i + 1));
            }
            Console.WriteLine("\n-----------------------------");
            Array.Copy(salaryValue, salaryValueLength, count);
            Array.Sort(salaryValue);
            int medianValue = 0;

            if(count %2 == 0)
            {
                int medianFirst = salaryValue[salaryValue.Length / 2];
                int medianSecond = salaryValue[salaryValue.Length / 2 - 1];
                medianValue = (medianFirst + medianSecond) / 2;
            }
            else
            {
                medianValue = salaryValue[salaryValue.Length / 2];
            }
            Console.WriteLine("Medianlön:       {0}", medianValue);
            Console.WriteLine("Medellön:        {0}", salaryValue.Average());
            Console.WriteLine("Lönespridning:   {0}", salaryValue.Max() - salaryValue.Min());
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < count; i++)
            {
                switch(i%3)
                {
                    case 0:
                        Console.Write("{0,8}",salaryValueLength[i]);
                        break;
                    case 1:
                        Console.Write("{0,8}", salaryValueLength[i]);
                        break;
                    case 2:
                        Console.WriteLine("{0,8}", salaryValueLength[i]);
                        break;
                }
            }
        }


        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());

            try
            {
                 catch(FormatException)
            }

        }

        }
}
