using SQLite;

namespace iandradeTS5.Models
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(25), Unique]
        public string Name { get; set; }
    }
}
