using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;


namespace DAL
{
    public class studentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;

        public int InsertCourse(CourseEntity en)
        {
            int cid = 0;
            try
            {
                con = DBconnect.GetConnection();
                con.Open();
                //string query = "insert into Course values(@cname,@fees,@dur)";
                cmd = new SqlCommand("sp_coures", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", en.Name);
                cmd.Parameters.AddWithValue("@fees", en.Fees);
                cmd.Parameters.AddWithValue("@dur", en.Duration);

                //int res = cmd.ExecuteNonQuery();
                //if (res > 0)
                //   return true;

                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@cid";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    cid = Convert.ToInt32(outparam.Value);

            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return cid;
        }

        public int InsertTeacher(TeacherEntity en)
        {
            int tid = 0;
            try
            {
                con = DBconnect.GetConnection();
                con.Open();
                //string query = "insert into Teacher values(@name,@sub,@Quali)";
                cmd = new SqlCommand("sp_teacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", en.Name);
                cmd.Parameters.AddWithValue("@sub", en.Sbject);
                cmd.Parameters.AddWithValue("@Quali", en.Qualification);
                //int res = cmd.ExecuteNonQuery();
                //if (res > 0)
                //    return true;

                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@tid";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    tid = Convert.ToInt32(outparam.Value);
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return tid;

        }

        public int InsertStudent(StudentEntity en)
        {
            int sid = 0;
            try
            {
                con = DBconnect.GetConnection();
                con.Open();
                cmd = new SqlCommand("sp_StudentInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fn", en.FName);
                cmd.Parameters.AddWithValue("@sn", en.SName);
                cmd.Parameters.AddWithValue("@ad", en.Address);
                cmd.Parameters.AddWithValue("@em", en.Email);
                cmd.Parameters.AddWithValue("@pin", en.PinCode);
                cmd.Parameters.AddWithValue("@con", en.Contact);
                cmd.Parameters.AddWithValue("@sd", en.StartDate);
                cmd.Parameters.AddWithValue("@ed", en.EndDate);
                cmd.Parameters.AddWithValue("@cid", en.CID);
                cmd.Parameters.AddWithValue("@tid", en.TID);
                cmd.Parameters.AddWithValue("@col", en.College);
                cmd.Parameters.AddWithValue("@fee", en.Fee);
                cmd.Parameters.AddWithValue("@det", en.Details);
                cmd.Parameters.AddWithValue("@fp", 0);
                cmd.Parameters.AddWithValue("@rf", en.Fee);

                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@sid";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();
                if (res > 0)
                    sid = Convert.ToInt32(outparam.Value);
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
            return sid;
        }


        public StudentEntity StudentProfile(int sid)
        {
            StudentEntity en = new StudentEntity();
            try
            {
                
                con = DBconnect.GetConnection();
                con.Open();
                string query = "select * from studentInfo where SID ="+sid;
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    en.FName = r[1].ToString();
                    en.SName = r[2].ToString();
                    en.Email = r[4].ToString();
                    en.Contact = Convert.ToInt64(r[6]);
                    en.College = r[11].ToString();
                    //en.Fee = Convert.ToInt64(r[12]);
                    en.CID = Convert.ToInt32(r[9]);
                    en.PaidFees = Convert.ToInt64(r[14]);
                    en.RemFees = Convert.ToInt64(r[15]);
                }
                else
                    throw new Exception("Enter Valid Student Id.");


            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return en;
        }


        public bool AddStudentFee(StudentEntity en)
        {
            try
            {
                con = DBconnect.GetConnection();
                con.Open();
                string query = "update studentInfo set CID =@cid,FeesPaid=@fp,RemFees=@rf where SID=@sid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", en.CID);
                cmd.Parameters.AddWithValue("@fp", en.PaidFees);
                cmd.Parameters.AddWithValue("@rf", en.RemFees);
                cmd.Parameters.AddWithValue("@sid", en.SID);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return false;
        }
    }
}
