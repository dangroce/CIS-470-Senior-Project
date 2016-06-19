/* *********************************************************************
    *  Etienne Rached (2009), Connect C# to MySQL.
    *  Retrieved from http://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
    *  
    *   http://stackoverflow.com/questions/14020038/filling-a-datatable-in-c-sharp-using-mysql
    *  The above reference was used to create the clsDataLayer
    *
*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for clsDatalayer
/// </summary>
public class clsDatalayer
{
    // Create a MySQL connection item;
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
 

    public clsDatalayer()
    {
        // Create the connecton to the Database
        Initializer();
    }

    public void Initializer()
    {
        string connectionStr = ConfigurationManager.ConnectionStrings["wscConnectionString1"].ToString();
        connectionStr = connectionStr.Split(';')[0].Split('=')[1];
        server = connectionStr;
        database = "wsc";
        uid = "Web01";
        password = "H1gh12SeaHawk!!";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);
    }
    //open connection to database
    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            //When handling errors, you can your application's response based 
            //on the error number.
            //The two most common error numbers when connecting are as follows:
            //0: Cannot connect to server.
            //1045: Invalid user name and/or password.
            switch (ex.Number)
            {
                case 0:
                    //MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    //MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    //Close connection
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            string my = ex.Message;
            return false;
        }
    }


    //Select statement
    public DataTable Select(string sqlStmt, string parm1 = "parm1", string parm2 = "parm2")
    {
        DataTable dsSelect = new DataTable();

        //string query = "SELECT `userlogin`, `firstname`, `lastname` FROM `wsc`.`users`;";

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            using (MySqlDataAdapter daUsers = new MySqlDataAdapter(cmd))
            {
                daUsers.Fill(dsSelect);
            }


            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return dsSelect;
        }
        else
        {
            return dsSelect;
        }
    }

    public DataTable mySelect(string sqlStmt, string parm1 = "parm1", string parm2 = "parm2")
    {
        DataTable dsMySelect = new DataTable();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            cmd.Parameters.AddWithValue("@parm1", parm1);
            cmd.Parameters.AddWithValue("@parm2", parm2);

            using (MySqlDataAdapter daUsers = new MySqlDataAdapter(cmd))
            {
                daUsers.Fill(dsMySelect);
            }



            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return dsMySelect;
        }
        else
        {
            return dsMySelect;
        }
    }

    public DataTable cntSelect(string sqlStmt, int parm1)
    {
        DataTable dsMySelect = new DataTable();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            cmd.Parameters.AddWithValue("@parm1", parm1);

            using (MySqlDataAdapter daUsers = new MySqlDataAdapter(cmd))
            {
                daUsers.Fill(dsMySelect);
            }



            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return dsMySelect;
        }
        else
        {
            return dsMySelect;
        }
    }
    public DataTable AddOrder(string sqlStmt, int prodid = 0, int userid = 0, int itemcnt = 0,
                        float amount = 0, string descript = "", float adj = 0, 
                        string orderdate = "" ,
                        int validation = 0, int fullfilled = 0)
    {
        DataTable dsAProd = new DataTable();


        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            if(prodid != 0)
            cmd.Parameters.AddWithValue("@parm1", prodid);
            if(userid != 0)
            cmd.Parameters.AddWithValue("@parm2", userid);
            if(itemcnt != 0)
            cmd.Parameters.AddWithValue("@parm3", itemcnt);
            if(amount != 0)
            cmd.Parameters.AddWithValue("@parm4", amount);
            if(descript != "")
            cmd.Parameters.AddWithValue("@parm5", descript);
            cmd.Parameters.AddWithValue("@parm6", adj);
                DateTime dt = Convert.ToDateTime(orderdate);
                cmd.Parameters.AddWithValue("@parm7", dt);
            cmd.Parameters.AddWithValue("@parm8", validation);
                cmd.Parameters.AddWithValue("@parm9", fullfilled);

            using (MySqlDataAdapter daOrder = new MySqlDataAdapter(cmd))
            {
                daOrder.Fill(dsAProd);
            }



            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return dsAProd;
        }
        else
        {
            return dsAProd;
        }
    }

    /*public bool createEditSingle(string sqlStmt, string param1, string param2 = "param2", 
                                    string param3 = "param3", string param4 = "param4"
                                , string param5 = "param5", string param6 = "param6", 
                                    string param7 = "param7", string param8 = "param8")
    {
        // To send back boolean value is set to false incase the IF false
        bool isValid = false;
        DataTable dtUser = new DataTable();
        DataTable dtCrtEdtSing = new DataTable();

        //Open connection
        if (this.OpenConnection()==true)
        {
            
            string query = "SELECT `userlogin`, `firstname`, `lastname` FROM `wsc`.`users`" +
                       " where `userlogin` = @parm1 and `passwrd` = @parm2;";

            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@parm1", param1);
            cmd.Parameters.AddWithValue("@parm2", param2);
            cmd.Parameters.AddWithValue("@parm3", param3);
            cmd.Parameters.AddWithValue("@parm4", param4);
            cmd.Parameters.AddWithValue("@parm5", param5);
            cmd.Parameters.AddWithValue("@parm6", param6);
            cmd.Parameters.AddWithValue("@parm7", param7);
            cmd.Parameters.AddWithValue("@parm8", param8);

            using (MySqlDataAdapter daUsers = new MySqlDataAdapter(cmd))
            {
                daUsers.Fill(dtCrtEdtSing);
            }



            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return dtUser;
        }
        else
        {
            return dtUser;
        }
    }*/

}

