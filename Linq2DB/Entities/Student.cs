using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Entities
{
    [Table(Name = "student")]
    public class Student: BaseEntity
    {
        [Column(Name = "fio")]
        public string FIO { get; set; }

        [Column(Name = "age")]
        public int Age { get; set; }

        public Student() { }

    }
}
