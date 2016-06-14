using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterFaculty.Entities
{
    public class MessageModel
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        public Category Category { get; set; }
        public DateTime? Date { get; set; }
        public Suffix Suffix { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string MessageBox { get; set; }
        public string StaffName { get; set; }
        public string Users { get; set; }

        
    }

    public enum Type
    {
        WalkIn = 0,
        Call = 1
    }

    public enum Suffix
    {
        Mr = 0,
        Mrs = 1
    }

    public enum Category
    {
        Moodle = 0,
        Project = 1,
        Posters = 2,
        Other = 3
    }
}
