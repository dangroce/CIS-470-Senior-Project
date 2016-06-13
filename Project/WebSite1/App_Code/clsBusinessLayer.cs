using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    clsDatalayer myDataLayer = new clsDatalayer();


    public clsBusinessLayer()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public DataTable loginUser(string username, string password)
    {
        // 
        // Datatable for users
        DataTable dsLogin = new DataTable();

        // try to get the users information
        try
        {
            string sqlStmt = "select * from `wsc`.`users` where `userlogin` = @parm1 and `passwrd` = @parm2;";

            dsLogin = myDataLayer.mySelect(sqlStmt, username, password);
        }
        catch(Exception error)
        {
            string theerror = error.ToString();
        }

        return dsLogin;
    }


    public DataTable ProductList()
    {
        DataTable myProducts = new DataTable();

        try
        {
            string sqlStmt = "select * from `wsc`.`product`;";

            myProducts = myDataLayer.mySelect(sqlStmt);
        }
        catch(Exception error)
        {
            string msg = error.ToString();
        }

        return myProducts;
    }
    
    public DataTable GetOrders(string userid)
    {
        DataTable dtGetOrders = new DataTable();

        try
        {
            string sqlStmt = "select * from `wsc`.`orders`;";

            dtGetOrders = myDataLayer.mySelect(sqlStmt, userid);
        }
        catch(Exception error)
        {
            string msg = error.ToString();
        }

        return dtGetOrders;
    }
}