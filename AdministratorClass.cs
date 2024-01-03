using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PracticeWork
{
    internal class AdministratorClass
    {

        dbconnector connect = new dbconnector();

        public bool insertAdministrator(int adid, string aduname, string adpass, string adfname, string adlname, DateTime adbDate, string adgender, string adphone, string adaddress)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `administratoruser` " +
                                                    "(`AdministratorUserID`, `AdministratorUsername`, `AdministratorPassword`, `AdName`, `AdSurname`, `AdBirthday`, `AdGender`, `AdPhone`, `AdAdress`) " +
                                                    "VALUES (@adid, @adun, @adps, @adfn, @adln, @adbD, @adgd, @adph, @adadr)", connect.getconnection);

            //@fname, @lname, bDate, gender, phone, @address
            command.Parameters.Add("@adid", MySqlDbType.Int32).Value = adid;
            command.Parameters.Add("@adun", MySqlDbType.VarChar).Value = aduname;
            command.Parameters.Add("@adps", MySqlDbType.VarChar).Value = adpass;
            command.Parameters.Add("@adfn", MySqlDbType.VarChar).Value = adfname;
            command.Parameters.Add("@adln", MySqlDbType.VarChar).Value = adlname;
            command.Parameters.Add("@adbD", MySqlDbType.Date).Value = adbDate;
            command.Parameters.Add("@adgd", MySqlDbType.VarChar).Value = adgender;
            command.Parameters.Add("@adph", MySqlDbType.VarChar).Value = adphone;
            command.Parameters.Add("@adadr", MySqlDbType.VarChar).Value = adaddress;

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


        public DataTable getAdministratorlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `administratoruser`", connect.getconnection);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable SearchAdministrator(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `administratoruser` WHERE CONCAT(`AdName`, `AdSurname`, `AdAdress`) LIKE @searchdata", connect.getconnection);

            command.Parameters.Add("@searchdata", MySqlDbType.VarChar).Value = "%" + searchdata + "%";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        public bool updateAdministrator(int adid, string aduname, string adpass, string adfname, string adlname, DateTime adbDate, string adgender, string adphone, string adaddress)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `administratoruser` " +
                                                    "SET `AdministratorUsername`=@adun, `AdministratorPassword`=@adps, `AdName`=@adfn, `AdSurname`=@adln, `AdBirthday`=@adbD, `AdGender`=@adgd, `AdPhone`=@adph, `AdAdress`=@adadr " +
                                                    "WHERE `AdministratorUserID`=@adid", connect.getconnection);

            command.Parameters.Add("@adid", MySqlDbType.Int32).Value = adid;
            command.Parameters.Add("@adun", MySqlDbType.VarChar).Value = aduname;
            command.Parameters.Add("@adps", MySqlDbType.VarChar).Value = adpass;
            command.Parameters.Add("@adfn", MySqlDbType.VarChar).Value = adfname;
            command.Parameters.Add("@adln", MySqlDbType.VarChar).Value = adlname;
            command.Parameters.Add("@adbD", MySqlDbType.Date).Value = adbDate;
            command.Parameters.Add("@adgd", MySqlDbType.VarChar).Value = adgender;
            command.Parameters.Add("@adph", MySqlDbType.VarChar).Value = adphone;
            command.Parameters.Add("@adadr", MySqlDbType.VarChar).Value = adaddress;

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

        public bool deleteAdministrator(int adid)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `administratoruser` WHERE `AdministratorUserID` =@adid", connect.getconnection);

            command.Parameters.Add("@adid", MySqlDbType.Int32).Value = adid;

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

    }
}
