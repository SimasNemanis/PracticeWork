using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticeWork
{
    internal class StudentClass
    {
        dbconnector connect = new dbconnector();

        public bool insertStudent(int stid, string uname, string pass, string fname, string lname, DateTime bDate, string gender, string phone, string address)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `studentuser` " +
                                                    "(`StudentUserID`, `StudentUsername`, `StudentPassword`, `StdFirstName`, `StdLastName`, `StdBirthdate`, `StdGender`, `StdPhone`, `StdAdress`) " +
                                                    "VALUES (@id, @un, @ps, @fn, @ln, @bD, @gd, @ph, @adr)", connect.getconnection);

            //@fname, @lname, bDate, gender, phone, @address
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bD", MySqlDbType.Date).Value = bDate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;

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


        public DataTable getStudentlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studentuser`", connect.getconnection);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable SearchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `studentuser` WHERE CONCAT(`StdFirstName`, `StdLastName`, `StdAdress`) LIKE @searchdata", connect.getconnection);

            command.Parameters.Add("@searchdata", MySqlDbType.VarChar).Value = "%" + searchdata + "%";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        public bool updateStudent(int stid, string uname, string pass, string fname, string lname, DateTime bDate, string gender, string phone, string address)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `studentuser` " +
                                                    "SET `StudentUsername`=@un, `StudentPassword`=@ps, `StdFirstName`=@fn, `StdLastName`=@ln, `StdBirthdate`=@bD, `StdGender`=@gd, `StdPhone`=@ph, `StdAdress`=@adr " +
                                                    "WHERE `StudentUserID`=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bD", MySqlDbType.Date).Value = bDate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;

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

        public bool deleteStudent(int stid)
        { 
            MySqlCommand command = new MySqlCommand("DELETE FROM `studentuser` WHERE `StudentUserID` =@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;

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

        public bool EnrollStudentInCourse(int stid, int Cid)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("INSERT INTO `studentuser_course` (StudentUserID, CourseID) VALUES (@id, @Cid)", connect.getconnection))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
                    command.Parameters.Add("@Cid", MySqlDbType.Int32).Value = Cid;

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
        public bool DeleteStudentInCourse(int stid, int Cid)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("DELETE FROM `studentuser_course` WHERE `StudentUserID` = @id AND `CourseID` = @Cid", connect.getconnection))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
                    command.Parameters.Add("@Cid", MySqlDbType.Int32).Value = Cid;

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
        public DataTable getStudent_Courselist()
        {

            MySqlCommand command = new MySqlCommand("SELECT studentuser.StudentUserID, studentuser.StdFirstName, studentuser.StdLastName, course.CourseID, course.CourseName " +
                   "FROM studentuser " +
                   "INNER JOIN studentuser_course ON studentuser.StudentUserID = studentuser_course.StudentUserID " +
                   "INNER JOIN course ON studentuser_course.CourseID = course.CourseID");
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }

}

