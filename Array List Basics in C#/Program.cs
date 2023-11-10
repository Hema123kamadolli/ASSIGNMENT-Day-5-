using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Basics_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1:ArrayList Initilization and Population
            int sum = 0;
            ArrayList StudentGrades = new ArrayList
            {
                85,92,78,95,88
            };

            //Task 2:Display and sum
            Console.WriteLine("Grades present in List is:" + StudentGrades.Count);
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum of all grades in studentGrades: ");
            foreach (int i in StudentGrades)
            {
                sum += (int)i;
            }
            Console.WriteLine($"The sum of the grades in studentgrades is {sum}");
            Console.WriteLine("**************************************************");
            Console.WriteLine("updates students grade after adding new data");
            
            //Task 3: Grade Addition

            StudentGrades.Add(90);
            foreach (int i in StudentGrades)
            {
                Console.Write(i);
            }
           Console.WriteLine("Removal of the contents in studentGrades");
           //Task 4: Grade Removal

            StudentGrades.RemoveAt(2);
            Console.WriteLine("**************************************************");
            Console.WriteLine("Updates students grade after Removing data");
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Updating the studentgrades list:");
            
            //Task 5: Search and Update

            StudentGrades.Insert(3, 96);
            foreach (int i in StudentGrades)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}


