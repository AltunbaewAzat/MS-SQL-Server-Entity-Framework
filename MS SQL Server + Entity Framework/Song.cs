using System;
using System.Data.Entity;

namespace MS_SQL_Server___Entity_Framework
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
