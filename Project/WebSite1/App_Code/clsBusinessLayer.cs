using System;
using System.Collections;
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

    public DataTable GetUser(string email = "@parm1", string fname = "@parm2", string lname = "@parm3")
    {
        DataTable guser = new DataTable();

        try
        {
            if(email != "@parm1" && fname != "@parm2" && lname != "@parm3")
            {
                string sqlStmt = "select * from wsc.users where email = @parm1 and firstname = @parm2 and lastname = @parm3;";
                guser = myDataLayer.mySelect(sqlStmt, email, fname, lname);

            }
            else if (email != "@parm1" && fname != "@parm2" && lname == "@parm3")
            {
                string sqlStmt = "select * from wsc.users where email = @parm1 and firstname = @parm2;";
                guser = myDataLayer.mySelect(sqlStmt, email, fname, lname);

            }
            else if (email != "@parm1" && fname == "@parm2" && lname == "@parm3")
            {
                string sqlStmt = "select * from wsc.users where email = @parm1;";
                guser = myDataLayer.mySelect(sqlStmt, email, fname, lname);

            }
            else if (email == "@parm1" && fname == "@parm2" && lname == "@parm3")
            {
                string sqlStmt = "select * from wsc.users;";
                guser = myDataLayer.mySelect(sqlStmt, email, fname, lname);

            }

        }
        catch(Exception e)
        {
            string msg = e.ToString();
        }

        return guser;
    }

    public bool updtUser(int typeid, string userlogin, string passwrd, string fname, string lname, 
        string City, string ustate, string phonenumber, string startdate, int  status = 0, 
        string middlename = "", string email = "", string enddate = "")
    {
        DataTable uuser = new DataTable();
        bool udtUser;

        try
        {

            string sqlStmt = "update wsc.users set typeid = @parm1, userlogin = @parm2, passwrd = @parm3, " +
                    "firstname = @parm4, lastname = @parm5, middlename = @parm6, email = @parm7, " +
                    "city = @parm8, ustate = @parm9, phonenumber = @parm10, startdate = @parm11, " +
                    "enddate = @parm12, status = @parm13;";

            udtUser = myDataLayer.AddUser(sqlStmt, typeid, userlogin, passwrd, fname, lname, middlename, email, City,
                ustate, phonenumber, startdate, enddate, status);

        }
        catch (Exception e)
        {
            string msg = e.ToString();
            udtUser = false;
        }

        return udtUser;
    }

    public DataTable CatagoryList()
    {
        DataTable myCatagory = new DataTable();

        try
        {
            string sqlStmt = "select * from `wsc`.`catalog` " +
                "as c left join `wsc`.`product` as p on c.`productid` = p.`productid`;";

            myCatagory = myDataLayer.mySelect(sqlStmt);
        }
        catch (Exception error)
        {
            string msg = error.ToString();
        }

        return myCatagory;
    }

    public DataTable OrdersList(int listType)
    {
        DataTable myProducts = new DataTable();
        string sqlStmt = "";
        try
        {
            switch (listType)
            {
                case 1:
                    sqlStmt = "select * from `wsc`.`product` where `validation` = 0 ;";

                    myProducts = myDataLayer.mySelect(sqlStmt);
                    break;
                case 2:
                    sqlStmt = "select * from `wsc`.`product` where `validation` > 0 ;";

                    myProducts = myDataLayer.mySelect(sqlStmt);
                    break;
                case 3:
                    sqlStmt = "select * from `wsc`.`product` where `validation` > 0 and char_length(fullfilled) > 0;";

                    myProducts = myDataLayer.mySelect(sqlStmt);
                    break;
            }
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
            string sqlStmt = "select * from `wsc`.`orders` where `userid` = @parm1;";

            dtGetOrders = myDataLayer.mySelect(sqlStmt, userid);
        }
        catch(Exception error)
        {
            string msg = error.ToString();
        }

        return dtGetOrders;
    }

    public int AddOrder(int userid, int item)
    {
        DataTable dtAOrder = new DataTable();
        DataTable dtProd = new DataTable();
        DataTable dtOrder = new DataTable();
        DataTable dtCnt = new DataTable();
        string sqlStmt = "";
        float prdamt = 0;
        string prdDesc = "";
        int itemCnt = 1;
        string dtTime = "";


        string sqlStmtProd = "select * from `wsc`.`product` where `productid` = @parm1;";
        string sqlStmtCnt = "select count(*) from `wsc`.`orders` where  `userid` = @parm1 and `validation` = 0;";

        dtProd = myDataLayer.mySelect(sqlStmtProd, item.ToString());

        if (dtProd.Rows.Count > 0)
        {
            prdamt = dtProd.Rows[0].Field<float>("retailcost");
            prdDesc = dtProd.Rows[0].Field<string>("productdescription");
        }


        string sqlStmtOrd = "select * from `wsc`.`orders` where  `itemid` = @parm1 and `userid` = @parm2 " +
                            "and `validation` = 0;";

        dtOrder = myDataLayer.AddOrder(sqlStmtOrd, item, userid,0,0,"",0,"1990/1/1 01:00:00.00");

        if (dtOrder.Rows.Count > 0)
        {
            itemCnt = dtOrder.Rows[0].Field<int>("itemcount") + 1;
            dtTime = dtOrder.Rows[0].Field<DateTime>("orderdate").ToString();

        }
        else
        {
            dtTime =DateTime.Now.ToString();
        }


        if (dtOrder.Rows.Count == 0 )
        {
            sqlStmt = "set foreign_key_checks = false;Insert into `wsc`.`orders` (`itemid`,`userid`,`itemcount`," +
                        "`amount`, `Description`,`adjustments`,`orderdate`,`validation`,`fullfilled`)" +
                        "values (@parm1, @parm2,@parm3, @parm4, @parm5, @parm6, @parm7, @parm8, @parm9); "+
                        "set foreign_key_checks = true;";
        }
        else
        {
            sqlStmt = "update `wsc`.`orders` set `itemid` = @parm1," +
                        "`userid` = @parm2,`itemcount` = @parm3,`amount` = @parm4, " +
                        "`Description` = @parm5,`adjustments` = @parm6," +
                        "`orderdate` = @parm7,`validation` = @parm8,`fullfilled` = @parm9;";
        }

            dtAOrder = myDataLayer.AddOrder(sqlStmt, item, userid,
                       itemCnt, prdamt, prdDesc, 0, dtTime, 0, 0);

        dtCnt = myDataLayer.cntSelect(sqlStmtCnt, userid);

        itemCnt = dtCnt.Rows[0].Field<int>(0);

        return itemCnt;
    }

}




