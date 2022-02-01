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

            DataConnection db = Linq2DB.Config.db;

            using (db)
            {
                var table = db.GetTable<Student>();

                students = table.ToList();

            }
            return students;
        }

        public static List<Student> FindFIO(string fio)
        {
            List<Student> students = new List<Student>();

            DataConnection db = Linq2DB.Config.db;

            using (db)
            {
                var table = db.GetTable<Student>().Where(x => x.FIO.Contains(fio));

                students = table.ToList();

            }
            return students;
        }

        public static List<Student> FindAge(int age)
        {
            List<Student> students = new List<Student>();

            DataConnection db = Linq2DB.Config.db;

            using (db)
            {
                var table = db.GetTable<Student>().Where(x => x.Age >= age);

                students = table.ToList();

            }
            return students;
        }
    }
}
