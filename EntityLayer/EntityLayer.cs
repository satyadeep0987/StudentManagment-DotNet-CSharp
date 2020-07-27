using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CourseEntity
    {
        public int CID { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public string Duration { get; set; }

    }
    public class TeacherEntity
    {
        public int TID { get; set; }
        public string Name { get; set; }
        public string Sbject { get; set; }
        public string Qualification { get; set; }
    }
    public class StudentEntity
    {
        public int SID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long PinCode { get; set; }
        public long Contact { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Details { get; set; }
        public int CID { get; set; }
        public string College { get; set; }
        public double Fee { get; set; }
        public int TID { get; set; }

        public double PaidFees { get; set; }
        public double RemFees { get; set; }

    }
}
