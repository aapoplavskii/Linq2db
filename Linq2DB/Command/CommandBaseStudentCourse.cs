using DZ_OTUS.Entities;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Command
{
    public static class CommandBaseStudentCourse
    {
        public static void WriteRecord(int studentid, int courseid)
        {

            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {
                var table = db.GetTable<StudentCourse>();

                table.Value(x => x.StudentID, studentid)
                     .Value(x => x.CourseID, courseid)
                     .Insert();

            }


        }

        internal static List<StudentCourse> ReadBase(string v1, int v2)
        {
            List<StudentCourse> studentCourses = new List<StudentCourse>();

            using (var db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, Linq2DB.Config.SqlConnectionString))
            {

                var query = from studentcourse in db.GetTable<StudentCourse>()
                            join student in db.GetTable<Student>()
                            on studentcourse.StudentID equals student.Id
                            join course in db.GetTable<Course>()
                            on studentcourse.CourseID equals course.Id
                            where student.Age < v2 && course.name.Contains(v1)
                            select studentcourse;



                studentCourses = query.ToList();

            }


            return studentCourses;
        }
    }
}
