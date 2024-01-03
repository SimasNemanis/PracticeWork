using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PracticeWork
{
    internal class TeacherClass
    {

        dbconnector connect = new dbconnector();

        public bool insertTeacher(int Tid, string Tuname, string Tpass, string Tfname, string Tlname, DateTime TbDate, string Tgender, string Tphone, string Taddress)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `teacheruser` " +
                                                    "(`TeacherUserID`, `TeacherUsername`, `TeacherPassword`, `TName`, `TSurname`, `TBirthday`, `TGender`, `TPhone`, `TAdress`) " +
                                                    "VALUES (@Tid, @Tun, @Tps, @Tfn, @Tln, @TbD, @Tgd, @Tph, @Tadr)", connect.getconnection);

            //@fname, @lname, bDate, gender, phone, @address
            command.Parameters.Add("@Tid", MySqlDbType.Int32).Value = Tid;
            command.Parameters.Add("@Tun", MySqlDbType.VarChar).Value = Tuname;
            command.Parameters.Add("@Tps", MySqlDbType.VarChar).Value = Tpass;
            command.Parameters.Add("@Tfn", MySqlDbType.VarChar).Value = Tfname;
            command.Parameters.Add("@Tln", MySqlDbType.VarChar).Value = Tlname;
            command.Parameters.Add("@TbD", MySqlDbType.Date).Value = TbDate;
            command.Parameters.Add("@Tgd", MySqlDbType.VarChar).Value = Tgender;
            command.Parameters.Add("@Tph", MySqlDbType.VarChar).Value = Tphone;
            command.Parameters.Add("@Tadr", MySqlDbType.VarChar).Value = Taddress;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }


        public DataTable getTeacherlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teacheruser`", connect.getconnection);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable SearchTeacher(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `teacheruser` WHERE CONCAT(`TName`, `TSurname`, `TAdress`) LIKE @searchdata", connect.getconnection);

            command.Parameters.Add("@searchdata", MySqlDbType.VarChar).Value = "%" + searchdata + "%";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        public bool updateTeacher(int Tid, string Tuname, string Tpass, string Tfname, string Tlname, DateTime TbDate, string Tgender, string Tphone, string Taddress)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `teacheruser` " +
                                                    "SET `TeacherUsername`=@Tun, `TeacherPassword`=@Tps, `TName`=@Tfn, `TSurname`=@Tln, `TBirthday`=@TbD, `TGender`=@Tgd, `TPhone`=@Tph, `TAdress`=@Tadr " +
                                                    "WHERE `TeacherUserID`=@id", connect.getconnection);

            command.Parameters.Add("@Tid", MySqlDbType.Int32).Value = Tid;
            command.Parameters.Add("@Tun", MySqlDbType.VarChar).Value = Tuname;
            command.Parameters.Add("@Tps", MySqlDbType.VarChar).Value = Tpass;
            command.Parameters.Add("@Tfn", MySqlDbType.VarChar).Value = Tfname;
            command.Parameters.Add("@Tln", MySqlDbType.VarChar).Value = Tlname;
            command.Parameters.Add("@TbD", MySqlDbType.Date).Value = TbDate;
            command.Parameters.Add("@Tgd", MySqlDbType.VarChar).Value = Tgender;
            command.Parameters.Add("@Tph", MySqlDbType.VarChar).Value = Tphone;
            command.Parameters.Add("@Tadr", MySqlDbType.VarChar).Value = Taddress;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool deleteTeacher(int Tid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `teacheruser` WHERE `TeacherUserID` =@Tid", connect.getconnection);

            command.Parameters.Add("@Tid", MySqlDbType.Int32).Value = Tid;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AssignTeacherToCourse(int Tid, int courseID)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("INSERT INTO `teacheruser_course` (TeacherUserID, CourseID) VALUES (@Tid, @courseid)", connect.getconnection))
                {
                    command.Parameters.Add("@Tid", MySqlDbType.Int32).Value = Tid;
                    command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseID;

                    connect.openConnect();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.closeConnect();
            }

            return false;
        }
        public bool DeleteTeacherToCourse(int Tid, int courseID)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("DELETE FROM `teacheruser_course` WHERE `TeacherUserID` = @Tid AND `CourseID` = @courseid", connect.getconnection))
                {
                    command.Parameters.Add("@Tid", MySqlDbType.Int32).Value = Tid;
                    command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseID;

                    connect.openConnect();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.closeConnect();
            }

            return false;
        }
        public DataTable getTeacher_Courselist()
        {
            MySqlCommand command = new MySqlCommand("SELECT teacheruser.TeacherUserID, teacheruser.TName, teacheruser.TSurname, course.CourseID, course.CourseName " +
                   "FROM teacheruser " +
                   "INNER JOIN teacheruser_course ON teacheruser.teacherUserID = teacheruser_course.teacherUserID " +
                   "INNER JOIN course ON teacheruser_course.CourseID = course.CourseID");
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
