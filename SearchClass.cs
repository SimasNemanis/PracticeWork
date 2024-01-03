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
    internal class SearchClass
    {
        private dbconnector connect = new dbconnector();

        public DataTable SearchStudent(string firstName, string lastName, string coursename)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM `studentuser` " +
                                                               "INNER JOIN `score` ON `studentuser`.`StudentUserID` = `score`.`StudentUserID` " +
                                                               "WHERE CONCAT(`StdFirstName`, ' ', `StdLastName`) LIKE CONCAT('%', @name, '%') " +
                                                               "AND `score`.`CourseName` LIKE CONCAT('%', @coursen, '%')", connect.getconnection))
                {
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = $"{firstName} {lastName}";
                    command.Parameters.Add("@coursen", MySqlDbType.VarChar).Value = coursename;

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connect.closeConnect();
            }
        }


    }

}
