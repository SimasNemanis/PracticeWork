using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace PracticeWork
{
    internal class CourseClass
    {
        dbconnector connect = new dbconnector();

        public bool insertCourse(int cid, string cName, int hr, string desc)
        { 
            MySqlCommand command = new MySqlCommand("INSERT INTO `Course` " +
                                                    "(`CourseID`, `CourseName`, `CourseHour`, `Description`) " +
                                                    "VALUES (@cid, @cn, @ch, @desc)", connect.getconnection);

            command.Parameters.Add("cid", MySqlDbType.Int32).Value = cid;
            command.Parameters.Add("cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("ch", MySqlDbType.VarChar).Value = hr;
            command.Parameters.Add("desc", MySqlDbType.VarChar).Value = desc;
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
        public DataTable getCourselist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `course`", connect.getconnection);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse(int cid, string cName, int hr, string desc = "")
        {
            MySqlCommand command;

            if (string.IsNullOrEmpty(desc))
            {
                // Update without description
                command = new MySqlCommand("UPDATE `course` " +
                                           "SET `CourseName`=@cn, `CourseHour`=@ch " +
                                           "WHERE `CourseID`=@id", connect.getconnection);
            }
            else
            {
                // Update with description
                command = new MySqlCommand("UPDATE `course` " +
                                           "SET `CourseName`=@cn, `CourseHour`=@ch, `Description`=@desc " +
                                           "WHERE `CourseID`=@id", connect.getconnection);
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            }

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = cid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = cName;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = hr;

            connect.openConnect();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                connect.closeConnect();
            }
        }

        public bool deleteCourse(int cid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `CourseID` =@cid", connect.getconnection);

            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid;

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
    }
}
