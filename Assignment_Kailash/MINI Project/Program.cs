using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
public class DatabaseHandler
{


    public static SqlConnection GetConnection()
    {
        SqlConnection con = new SqlConnection("data source=kailash22\\SQLEXPRESS;Initial Catalog=test22;" +
                "Integrated Security=true;");
        con.Open();
        return con;
    }
    public class EmployeeHandler
    {



        public static void CloseConnection(SqlConnection con)
        {
            con.Close();
        }


        public static void InsertEmp(decimal EMPNO, string ENAME, string job, decimal sal)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("InsertEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@Salary", sal);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEmp(decimal EMPNO, string ENAME, string job, decimal sal)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("UpdateEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.Parameters.AddWithValue("@Name", ENAME);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@Salary", sal);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEmp(decimal EMPNO)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("DeleteEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPNO", EMPNO);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllEmp()
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("GetAllEmp", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }

            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Insert new employee");
                Console.WriteLine("2. Update employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. View all employees");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Employee no: ");
                        decimal EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Employee name: ");
                        string ENAME = Console.ReadLine();
                        Console.Write("Employee job: ");
                        string job = Console.ReadLine();
                        Console.Write("Employee salary: ");
                        decimal sal = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.InsertEmp(EMPNO, ENAME, job, sal);
                        Console.WriteLine("Employee added successfully");
                        break;

                    case "2":
                        Console.Write("Employee no: ");
                        EMPNO = decimal.Parse(Console.ReadLine());
                        Console.Write("Employee name: ");
                        ENAME = Console.ReadLine();
                        Console.Write("Employee job: ");
                        job = Console.ReadLine();
                        Console.Write("Employee salary: ");
                        sal = decimal.Parse(Console.ReadLine());
                        EmployeeHandler.UpdateEmp(EMPNO, ENAME, job, sal);
                        Console.WriteLine("Employees updated successfully");
                        break;

                    case "3":
                        Console.Write("Employee no: ");
                        EMPNO = int.Parse(Console.ReadLine());
                        EmployeeHandler.DeleteEmp(EMPNO);
                        Console.WriteLine("Employee deleted successfully");
                        break;

                    case "4":
                        DataTable employees = EmployeeHandler.GetAllEmp();
                        foreach (DataRow row in employees.Rows)
                        {
                            Console.WriteLine($"ID: {row["EMPNO"]}, Name: {row["ENAME"]}, Job: {row["job"]}, Salary: {row["Sal"]}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("VALID!");
                        return;

                    default:
                        Console.WriteLine("Invalid ");
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}