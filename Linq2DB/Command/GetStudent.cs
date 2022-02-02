using DZ_OTUS.Entities;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Command
{
    public static class GetStudent
    {
        public static List<Student> FindAll()
        {
            List<Student> students = new List<Student>();

            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<Student>();

                students = table.ToList();

            }
            return students;
        }

        public static List<Student> FindFIO(string fio)
        {
            List<Student> students = new List<Student>();

            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<Student>().Where(x => x.FIO.Contains(fio));

                students = table.ToList();

            }
            return students;
        }

        public static List<Student> FindAge(int age)
        {
            List<Student> students = new List<Student>();

            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<Student>().Where(x => x.Age < age);

                students = table.ToList();

            }
            return students;
        }

        public static Student FindItem(int id)
        {
            Student student = null;


            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                student = db.GetTable<Student>().FirstOrDefault(x => x.Id == id);

            }
            return student;
        }
    }
}
