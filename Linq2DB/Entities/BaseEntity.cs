using LinqToDB.Mapping;

namespace DZ_OTUS.Entities
{
    public class BaseEntity
    {

        [PrimaryKey]
        [Column(Name = "id")]
        public int Id { get; set; }

    }
}
