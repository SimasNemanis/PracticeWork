using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeWork
{
    internal class ScoreClass
    {
        dbconnector connect = new dbconnector();

        public bool insertScore(int stdid, string crName, double scor, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score` " +
                                                    "(`StudentUserID`, `CourseName`, `Score`, `Description`) " +
                                                    "VALUES (@id, @cn, @sc, @desc)", connect.getconnection);

            //@fname, @lname, bDate, gender, phone, @address
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = crName;
            command.Parameters.Add("@sc", MySqlDbType.Double).Value = scor;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;


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
        public bool checkScore(int stid, string crName)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `StudentUserID` = '"+ stid +"' AND `CourseName` = '"+ crName +"'", connect.getconnection);
            command.Parameters.AddWithValue("@stid", stid);
            command.Parameters.AddWithValue("@crName", crName);

            DataTable table = getList(command);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateScore(int stid, string crName, double scor, string desc = "")
        {
            MySqlCommand command;

            if (string.IsNullOrEmpty(desc))
            {
                // Update without description
                command = new MySqlCommand("UPDATE `score` " +
                                           "SET `CourseName`=@cn, `Score`=@sc " +
                                           "WHERE `StudentUserID`=@id", connect.getconnection);
            }
            else
            {
                // Update with description
                command = new MySqlCommand("UPDATE `score` " +
                                           "SET `CourseName`=@cn, `Score`=@sc, `Description`=@desc " +
                                           "WHERE `StudentUserID`=@id", connect.getconnection);
                command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            }

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = crName;
            command.Parameters.Add("@sc", MySqlDbType.Double).Value = scor;

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

        public bool deleteScore(int stid, string crName)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `StudentUserID` = @id AND `CourseName` = @cn", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = stid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = crName;

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
