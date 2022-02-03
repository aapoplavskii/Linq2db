using DZ_OTUS.Command;
using System;

namespace Linq2DB
{
    public class Program
    {
        static void Main(string[] args)
        {

            ReadDataBase();
            WriteDataBase();
            ReadDataStudentCourse();
            

        }

        private static void ReadDataStudentCourse()
        {
            Console.WriteLine();

            Console.WriteLine("Вывожу данные по курсам, у которых в названии есть буква 'J'," +
                "\nдля студентов, младше 30:");

            var listcourse = CommandBaseStudentCourse.ReadBase("J", 30);

            foreach (var item in listcourse)
            {
                var course = GetCourse.FindItem(item.CourseID);
                var student = GetStudent.FindItem(item.StudentID);

                Console.WriteLine($"{student} - {course} (id записи - {item.Id})");
            
            }
        }

        private static void WriteDataBase()
        {
            Console.WriteLine("Введите данные по курсам (студент - курс)."); 

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Введите ID студента");

                var student = Console.ReadLine();

                Console.WriteLine("Введите ID курса");

                var course = Console.ReadLine();

                if (int.TryParse(course, out int courseid) && int.TryParse(student, out int studentid))
                {
                    CommandBaseStudentCourse.WriteRecord(studentid, courseid);
                }
                else
                {
                    Console.WriteLine("Введены некорректные данные по id");
                }

                Console.WriteLine("Для продолжения ввода Enter, для выхода нажмите Esc");
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }



            }

        }

        private static void ReadDataBase()
        {
            Console.WriteLine("Список студентов:");

            GetStudent.FindAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            Console.WriteLine("Список курсов");

            GetCourse.FindAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            Console.WriteLine("Список студентов младше 30 лет:");

            GetStudent.FindAge(30).ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            Console.WriteLine("Список курсов, содержащих букву 'J':");

            GetCourse.FindName("J").ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
        }
    }
}
