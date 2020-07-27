using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EntityLayer;
using DAL;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BAL
{
    public class studentBAL
    {
        studentDAL dal = new studentDAL();
        //public bool InsertCourse(CourseEntity en) //Without store procedure

        public int InsertCourse(CourseEntity en)
        {
            if (string.IsNullOrEmpty(en.Name))
                throw new Exception("Name cannot be blank");
            if (en.Fees < 1000)
                throw new Exception("Enter Correct fees");
            if (string.IsNullOrEmpty(en.Duration))
                throw new Exception("Duration cannot be blank");
            return dal.InsertCourse(en);

        }
        public int InsertTeacher(TeacherEntity en)
        {

            if (string.IsNullOrEmpty(en.Name))
                throw new Exception("Name cannot be blank");
            if (string.IsNullOrEmpty(en.Sbject))
                throw new Exception("Sbject cannot be blank");
            if (string.IsNullOrEmpty(en.Qualification))
                throw new Exception("Name cannot be blank");
            return dal.InsertTeacher(en);
        }

        public int InsertStudent(StudentEntity en)
        {
            if (string.IsNullOrEmpty(en.FName) || string.IsNullOrEmpty(en.SName))
                throw new Exception("First Name and Surname cannot be blank");

            if (string.IsNullOrEmpty(en.Address))
                throw new Exception("Address cannot be Empty");


            string exp1 = @"^\S+@\S+$";
            Regex Email = new Regex(exp1);
            if (Email.IsMatch(en.Email) != true)
                throw new Exception("Enter Correct email");

            string exp2 = @"\d{6}";
            Regex pincode = new Regex(exp2);
            if (pincode.IsMatch(en.PinCode.ToString()) != true)
                throw new Exception("Enter mobie no Correct");

            string exp = @"\d{10}";
            Regex mobno = new Regex(exp);
            if (mobno.IsMatch(en.Contact.ToString()) != true)
                throw new Exception("Enter mobie no Correct");

            if (en.Fee < 1000)
                throw new Exception("Enter Correct Fee");

            return dal.InsertStudent(en);
        }

        public StudentEntity StudentProfile(int sid)
        {
            if (string.IsNullOrEmpty(sid.ToString()))
                throw new Exception("Student Id is emplty");
            return dal.StudentProfile(sid);
        }


        public bool AddStudentFee(StudentEntity en)
        {

            return dal.AddStudentFee(en);
        }
    }
}

