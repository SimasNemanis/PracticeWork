using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWork
{
    internal class GroupClass
    {

        dbconnector connect = new dbconnector();

        public bool insertGroup(int Gid, string GName)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `groups` " +
                                                    "(`GroupID`, `GroupName`) " +
                                                    "VALUES (@Gid, @gn)", connect.getconnection);

            //@fname, @lname, bDate, gender, phone, @address
            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = Gid;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = GName;


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


        public DataTable getGrouplist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groups`", connect.getconnection);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable SearchGroups(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `groups` WHERE CONCAT(`GroupID`, `GroupName`) LIKE @searchdata", connect.getconnection);

            command.Parameters.Add("@searchdata", MySqlDbType.VarChar).Value = "%" + searchdata + "%";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        public bool updateGroup(int Gid, string GName)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `groups` " +
                                                    "SET `GroupID`=@Gid, `GroupName`=@gn " +
                                                    "WHERE `GroupID`=@id", connect.getconnection);

            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = Gid;
            command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = GName;


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

        public bool deleteGroup(int Gid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `groups` WHERE `GroupID` =@Gid", connect.getconnection);

            command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = Gid;

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
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool AssignCourseToGroup(int Gid, int Cid)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("INSERT INTO `groups_course` (GroupID, CourseID) VALUES (@Gid, @Cid)", connect.getconnection))
                {
                    command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = Gid;
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
        public bool DeleteCourseToGroup(int Gid, int Cid)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("DELETE FROM `groups_course` WHERE `GroupID` = @Gid AND `CourseID` = @Cid", connect.getconnection))
                {
                    command.Parameters.Add("@Gid", MySqlDbType.Int32).Value = Gid;
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
        public DataTable getGroup_Courselist()
        {
            MySqlCommand command = new MySqlCommand("SELECT `groups`.GroupID, `groups`.GroupName, course.CourseID, course.CourseName " +
            "FROM `groups` " +
            "INNER JOIN groups_course ON `groups`.GroupID = groups_course.GroupID " +
            "INNER JOIN course ON groups_course.CourseID = course.CourseID");
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

    }
}
