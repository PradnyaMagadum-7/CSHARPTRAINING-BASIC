using Microsoft.Data.SqlClient;
using System.Data;


namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //connect();
            //Insert();
            Employee obj = new Employee { EmpNo = 7,EmpName ="Nikhil", Basic = 12345, DeptNo = 30 };
            //InsertEmployee(obj);
            //InsertWithParameters(obj);
            //InsertStoredProcedure(obj);
            // UpdateStoredProcedure(obj);
            DeleteStoredProcedure(obj);
        }

        static void connect()
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass

            //possiblity so put in try and catch

            try
            {
                conn.Open();
                Console.WriteLine("Okay");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void Insert()
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = "insert into Employees values (4,'Pooja',12345,10)";
                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void InsertEmployee(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = $"insert into Employees values ({obj.EmpNo},'{obj.EmpName}',{obj.Basic},{obj.DeptNo})"; //string interpolation >>> generally dont use 
                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void InsertWithParameters(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = "insert into Employees values (@EmpNo, @EmpName, @Basic, @DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void InsertStoredProcedure(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrathttps://drive.google.com/drive/folders/1u4NX4vDiAdxu2ZQqNb7D8n31_Q3l2Lsoed Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void UpdateStoredProcedure(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrathttps://drive.google.com/drive/folders/1u4NX4vDiAdxu2ZQqNb7D8n31_Q3l2Lsoed Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = "UpdateEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        static void DeleteStoredProcedure(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrathttps://drive.google.com/drive/folders/1u4NX4vDiAdxu2ZQqNb7D8n31_Q3l2Lsoed Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;  //first choice always be stored procedure // but in some cases you dont have 
                cmd.CommandText = "DeleteEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
        

                cmd.ExecuteNonQuery();//running above query
                Console.WriteLine("Okay");              //stored procedure use text
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public decimal Basic { get; set; }
        public decimal DeptNo { get; set; }
    }
}