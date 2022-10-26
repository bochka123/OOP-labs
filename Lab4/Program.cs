using System;
using System.Linq;
/*
* Oleksandr Tkach
* number of the score book - 328
* C11 - 9  
*/
namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Oleksandr", "Tkach", 19, "IO-03");
            Student student2 = new Student("Nazariy", "Tymchyshyn", 12, "IO-05");
            Student student3 = new Student("Yevgen", "Yakubovskiy", 22, "IO-01");
            Student student4 = new Student("Nadia", "Prokhorchuk", 33, "IO-04");
            Student student5 = new Student("Oleksiy", "Kovtun", 17, "IO-02");
            Student student6 = new Student("Yaroslav", "Bugayov", 99, "IO-07");
            Student student7 = new Student("Vladislav", "Haydish", 40, "IO-06");
            Student[] students = { student1, student2, student3, student4, student5, student6, student7 };

            var sortedAge = students.OrderBy(student => student.age).ToArray();
            Console.WriteLine("Sorting of age by growing: ");
            foreach (Student student in sortedAge)
            {
                Console.WriteLine($"{student.firstName}: {student.age}");
            }
            Console.WriteLine();

            var sortedAgeReversed = sortedAge.Reverse();
            Console.WriteLine("Sorting of age by descending: ");
            foreach (Student student in sortedAgeReversed)
            {
                Console.WriteLine($"{student.firstName}: {student.age}");
            }
            Console.WriteLine();

            var sortedFirstName = students.OrderBy(student => student.firstName).ToArray();
            Console.WriteLine("Sorting of firstname by growing: ");
            foreach (Student student in sortedFirstName)
            {
                Console.WriteLine($"{student.firstName}");
            }
            Console.WriteLine();

            var sortedFirstNameReversed = sortedFirstName.Reverse();
            Console.WriteLine("Sorting of firstname by descending: ");
            foreach (Student student in sortedFirstNameReversed)
            {
                Console.WriteLine($"{student.firstName}");
            }
            Console.WriteLine();

            var sortedLastName = students.OrderBy(student => student.lastName).ToArray();
            Console.WriteLine("Sorting of lastname by growing: ");
            foreach (Student student in sortedLastName)
            {
                Console.WriteLine($"{student.firstName}: {student.lastName}");
            }
            Console.WriteLine();

            var sortedLastNameReversed = sortedLastName.Reverse();
            Console.WriteLine("Sorting of lastname by descending: ");
            foreach (Student student in sortedLastNameReversed)
            {
                Console.WriteLine($"{student.firstName}: {student.lastName}");
            }
            Console.WriteLine();

            var sortedGroup = students.OrderBy(student => student.group).ToArray();
            Console.WriteLine("Sorting of group by growing: ");
            foreach (Student student in sortedGroup)
            {
                Console.WriteLine($"{student.firstName}: {student.group}");
            }
            Console.WriteLine();

            var sortedGroupReversed = sortedGroup.Reverse();
            Console.WriteLine("Sorting of group by descending: ");
            foreach (Student student in sortedGroupReversed)
            {
                Console.WriteLine($"{student.firstName}: {student.group}");
            }
            Console.WriteLine();

            var sortedId = students.OrderBy(student => student.id).ToArray();
            Console.WriteLine("Sorting of id by growing: ");
            foreach (Student student in sortedId)
            {
                Console.WriteLine($"{student.firstName}: {student.id}");
            }
            Console.WriteLine();

            var sortedIdReversed = sortedId.Reverse();
            Console.WriteLine("Sorting of id by descending: ");
            foreach (Student student in sortedIdReversed)
            {
                Console.WriteLine($"{student.firstName}: {student.id}");
            }
            Console.WriteLine();
        }
    }
}
