using System;
using System.Data.SqlClient;//צריך להוסיף בנאגטס

namespace L20200520_Databases
{
    /**
   * Three methods to work with databases in C#:
   * 1. The connected layer.
   * 2. The disconnected layer.
   * 3. Entity Framework.
   * 
   */
    class Program
    {
        const string connString = @"Data Source=DESKTOP-SFAD2JC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static void Main(string[] args)
        {

            //Select("SELECT FirstName, LastName FROM Employees", (dr) =>
            //{
            //    string firstName = dr.GetString(0);//אנחנו שולפים מחרוזת מעמודה במקום האפס 
            //    string LastName = dr.GetString(1);
            //    Console.WriteLine(firstName + " " + LastName);
            //    return (firstName == "Andrew");
            //});

            //------------------------------------------------------------------------------>
            //Select("SELECT FirstName, LastName FROM Employees", (dr) =>
            //{
            //    string firstName = dr.GetString(0);//אנחנו שולפים מחרוזת מעמודה במקום האפס 
            //    string LastName = dr.GetString(1);
            //    Console.WriteLine(firstName + " " + LastName);
            //});

            //---------------------------------------------------------------------------------->

            //Select("SELECT COUNT(EmployeeID) FROM Employees", (dr) =>
            //{
            //    int count = dr.GetInt32(0);
            //    Console.WriteLine("there are {0} employees", count);
            //});
            //------------------------------------------------------------------------------------>

            //int count = 0;
            //Select("SELECT EmployeeID FROM Employees", (dr) =>
            //{
            //    count++;
            //});
            //Console.WriteLine("there are {0} employees", count);
            //----------------------------------------------------------------------------------------->

            //Select("SELECT EmployeeID FROM Employees", (dr) =>
            //{
            //    int employeeId = dr.GetInt32(0);
            //    Console.WriteLine("employee id: {0}", employeeId);
            //});


            //-------------------------------------------------------------------------->

            // מה שיש בסוגריים מייצג בעצם טבלה

            //Select("SELECT EmployeeID FROM (SELECT EmployeeID FROM Employees) AS Table1", (dr) =>
            //{
            //    int employeeId = dr.GetInt32(0);
            //    Console.WriteLine("employee id: {0}", employeeId);
            //});

            //-------------------------------------------------------------------------------->

            //Select("SELECT FirstName, LastName FROM Employees WHERE City='London' OR City='Tacoma'", (dr) =>
            //{
            //    string firstName = dr.GetString(0);
            //    string LastName = dr.GetString(1);
            //    Console.WriteLine(firstName + " " + LastName);
            //});

            //-------------------------------------------------------------------------------------->

            //Select("SELECT FirstName, LastName, City FROM Employees WHERE City IN ('London', 'Tacoma')", (dr) =>
            //{
            //    string firstName = dr.GetString(0);
            //    string LastName = dr.GetString(1);
            //    string city = dr.GetString(2);
            //    Console.WriteLine(firstName + " " + LastName + " " + city);
            //});

            //------------------------------------------------------------------------------------------------>

            //Select("SELECT FirstName, LastName FROM Employees WHERE City LIKE '%London%'", (dr) =>
            //{
            //    string firstName = dr.GetString(0);
            //    string LastName = dr.GetString(1);
            //    Console.WriteLine(firstName + " " + LastName);
            //});

            //------------------------------------------------------------------------------------------------------->
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    conn.Open();//פותח את הדאתאבייס
            //    Console.WriteLine("successfully connected to db");
            //    using (SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName FROM Employees", conn))
            //    {
            //        using (SqlDataReader dr = cmd.ExecuteReader())
            //        {
            //            while (dr.Read())
            //            {
            //                string firstName = dr.GetString(0);//אנחנו שולפים מחרוזת מעמודה במקום האפס 
            //                string LastName = dr.GetString(1);
            //                Console.WriteLine(firstName + " " + LastName);
            //            }
            //        }
            //    }

            //}

            //---------------------------------------------------------------------------------------->
            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //    conn.Open();
            //    using (SqlCommand cmd = new SqlCommand("INSERT INTO Students(FirstName, LastName, Age) Values (@FirstName, @LastName, @Age)", conn))
            //    {
            //        cmd.Parameters.AddWithValue("@FirstName", "Elad");
            //        cmd.Parameters.AddWithValue("@LastName", "Lavi");
            //        cmd.Parameters.AddWithValue("@Age", 38);
            //        int rowsAffected = cmd.ExecuteNonQuery();
            //        if(rowsAffected==1)
            //            Console.WriteLine("inserted successfully");
            //    }
            //}
            //--------------------------------------------------------------------------------->

            //if (Modify("INSERT INTO Students(FirstName, LastName, Age) VALUES (@FirstName, @LastName, @Age)", (cmd) =>
            //{
            //    cmd.Parameters.AddWithValue("@FirstName", "Nati");
            //    cmd.Parameters.AddWithValue("@LastName", "Sva");
            //    cmd.Parameters.AddWithValue("@Age", 18);

            //}) == 1) { Console.WriteLine("inserted successfully"); }

            //------------------------------------------------------------------------------------------------>

            //if (Modify("UPDATE Students SET Age=@Age WHERE StudentID=@StudentID", (cmd) =>
            //{
            //    cmd.Parameters.AddWithValue("@StudentID", 1);
            //    cmd.Parameters.AddWithValue("@Age", 39);
            //}) == 1) { }

            //--------------------------------------------------------------------------------------->

            //int rowsAffected = Modify("UPDATE Students SET Age=Age+5");
            //Console.WriteLine("rowsAffected :{0}", rowsAffected);

            //--------------------------------------------------------------------------------------->

            //Select("SELECT FirstName, MAX(Age) FROM Students GROUP BY FirstName", (dr)=> {
            //    Console.WriteLine("max age is: {0} {1}",dr.GetString(0), dr.GetInt32(1));//מחזיר עבור כל שם את הגיל הגדול ביותר שלו כלומר אם יש לנו את אותו שם מס' פעמים נקבל את הגיל הגדול
            //});

            //------------------------------------------------------------------------------------------>

            //Select("SELECT FirstName, Age FROM Students WHERE Age=(SELECT MAX(Age) From Students)", (dr) =>
            //{
            //    Console.WriteLine("{0} {1}", dr.GetString(0), dr.GetInt32(1));//מחזיר את השם והגיל הגדול ביותר 
            //});

            //----------------------------------------------------------------------------------------------------------->

            //get the customer with the most orders//****

            //Select("SELECT CustomerID, COUNT(OrderID) FROM Orders GROUP BY CustomerID",(dr)=> {
            //    Console.WriteLine("{0} {1}",dr.GetString(0),dr.GetInt32(1));//מחזיר את כמות ההזמנות עבור כל לקוח 

            //});
            //-------------------------------------------------------------------

            //Select("SELECT MAX(Count1) AS Max FROM (SELECT CustomerID, COUNT(OrderID) AS Count1 FROM Orders GROUP BY CustomerID) AS Table1", (dr) => {
            //    Console.WriteLine("{0}", dr.GetInt32(0));//מחזיר את כמות ההזמנה הגדולה ביותר 

            //});
            //---------------------------------------------------------------------------------------------------------->


            //Select("SELECT CustomerID, Count1 FROM (SELECT CustomerID, COUNT(OrderID) AS Count1 FROM Orders GROUP BY CustomerID) AS Table2 WHERE Count1 = (SELECT MAX(Count1) AS Max FROM (SELECT CustomerID, COUNT(OrderID) AS Count1 FROM Orders GROUP BY CustomerID) AS Table1)", (dr) => {
            //    Console.WriteLine("{0} {1}", dr.GetString(0),dr.GetInt32(1));//מחזיר את כמות ההזמנה הגדולה ביותר 

            //});

            Console.ReadLine();
        }


        public static int Modify(string modifyStatement, Action<SqlCommand> setParameters)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();//פותח את הדאתאבייס
                using (SqlCommand cmd = new SqlCommand(modifyStatement, conn))
                {
                    if(setParameters != null)
                    setParameters(cmd);
                    return cmd.ExecuteNonQuery();
                }

            }
        }


        public static int Modify(string modifyStatement)
        {
            return Modify(modifyStatement, null);
        }


        public static void Select(string selectStatement, Action<SqlDataReader> action)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();//פותח את הדאתאבייס
                using (SqlCommand cmd = new SqlCommand(selectStatement, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            action(dr);
                        }
                    }
                }

            }
        }

        public static void Select(string selectStatement, Func<SqlDataReader, bool> action)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();//פותח את הדאתאבייס
                using (SqlCommand cmd = new SqlCommand(selectStatement, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (action(dr))
                                break;
                        }
                    }
                }

            }
        }


    }


   
}
