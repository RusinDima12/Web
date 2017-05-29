using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web2.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; } // название картинки
        public string ClickName { get; set; }
        public string ClickText { get; set; }
        public string NameSubject { get; set; }
        public string UrlVideo { get; set; }
        public byte[] Image { get; set; }
        public string bilibirda { get; set; }
    }
    public class SubjectContext : DbContext
    {
        public SubjectContext()
            : base("DefaultConnection")
        { }

        public DbSet<SubjectModel> Subjects { get; set; }
    }
}