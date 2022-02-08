// See https://aka.ms/new-console-template for more information


using System;

namespace day1_practice_program;

class Progrma
{
    public static void Main(string[] args)
    {
        calculate(20);
    }

    static void calculate (int maxDays)
    {
        int workingHr = 0;
        int perHrSalary = 20;
        int totalSalary = 0;


        for (int day = 1; day <= maxDays; day++)

        {
            Random random = new Random();
            int present = (random.Next(3));
            switch (present)
            {

                case 0:
                    workingHr = 0;
                    break;
                    case 1:
                    workingHr = 4;
                    break;
                case 2:
                    workingHr = 8;
                    break;
                    default:
                    Console.WriteLine(" error ");
                    break;

            }
            int salary = perHrSalary + (workingHr * perHrSalary);
            totalSalary = totalSalary + salary;

        }
        Console.WriteLine($" employee earned:{totalSalary}");

    }

}