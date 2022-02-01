using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Entities
{
    [Table(Name = "studentcourse")]
    public class StudentCourse: BaseEntity
    {
        [Column(Name = "studentid")]
        public int StudentID { get; set; }

        [Column(Name = "courseid")]
        public int CourseID     { get; set; }

        public StudentCourse() { }

    }
}
