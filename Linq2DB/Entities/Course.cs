using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_OTUS.Entities
{
    [Table(Name = "course")]
    public class Course: BaseEntity
    {
        [Column(Name = "name")]
        public string name { get; set; }

        public Course() { }

    }
}
