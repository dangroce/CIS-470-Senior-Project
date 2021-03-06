﻿/* *********************************************************************
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

    public DataTable mySelect(string sqlStmt, string parm1 = "parm1", string parm2 = "parm2", string parm3 = "parm3")
    {
        DataTable dsMySelect = new DataTable();

        //Open connection
        if (this.OpenConnection() == true)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            cmd.Parameters.AddWithValue("@parm1", parm1);
            cmd.Parameters.AddWithValue("@parm2", parm2);
            cmd.Parameters.AddWithValue("@parm3", parm3);

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

    public int cntSelect(string sqlStmt, int parm1)
    {
        DataTable dsMySelect = new DataTable();
        int cntItem = 0;

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

            if(dsMySelect.Rows != null)
            {
                cntItem = Convert.ToInt32(dsMySelect.Rows[0][0].ToString());
            }

            //return list to be displayed
            return cntItem;
        }
        else
        {
            return 0;
        }
    }


    public bool AddUser(string sqlStmt, int typeid, string userlogin, string passwrd, string fname,
            string lname, string middlename, string email, string City, string ustate, string phonenumber,
            string startdate, string enddate, int status)
    {
        DataTable aUser = new DataTable();
        DateTime temp;
        bool GoodAdd = true;

        if (this.OpenConnection() == true)
        {
            MySqlCommand cmd = new MySqlCommand(sqlStmt, connection);

            cmd.Parameters.AddWithValue("@parm1", typeid);
            cmd.Parameters.AddWithValue("@parm2", userlogin);
            cmd.Parameters.AddWithValue("@parm3", passwrd);
            cmd.Parameters.AddWithValue("@parm4", fname);
            cmd.Parameters.AddWithValue("@parm5", lname);
            cmd.Parameters.AddWithValue("@parm6", middlename);
            cmd.Parameters.AddWithValue("@parm7", email);
            cmd.Parameters.AddWithValue("@parm8", City);
            cmd.Parameters.AddWithValue("@parm9", ustate);
            cmd.Parameters.AddWithValue("@parm10", phonenumber);
            DateTime dt = Convert.ToDateTime(startdate);
            cmd.Parameters.AddWithValue("@parm11", dt);
            if (DateTime.TryParse(enddate, out temp))
            {
                DateTime dte = Convert.ToDateTime(enddate);
                cmd.Parameters.AddWithValue("@parm12", dt);
            }
            else
            {
                cmd.Parameters.AddWithValue("@parm12", null);
            }
            cmd.Parameters.AddWithValue("@parm13", status);

        }
        else
        {
            GoodAdd = false;
        }
        return GoodAdd;
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


}

