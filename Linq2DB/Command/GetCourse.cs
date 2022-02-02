using DZ_OTUS.Entities;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Command
{
    public static class GetCourse
    {
        public static List<Course> FindAll()
        {
            List<Course> courses = new List<Course>();

           
            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<Course>();

                courses = table.ToList();

            }
            return courses;
        }

        public static List<Course> FindName(string name)
        {
            List<Course> courses = new List<Course>();

            
            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<Course>().Where(x => x.name.Contains(name));

                courses = table.ToList();

            }
            return courses;
        }

        public static Course FindItem(int id)
        {
            Course course = null;


            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                course = db.GetTable<Course>().FirstOrDefault(x => x.Id == id);

            }
            return course;
        }



    }
}
