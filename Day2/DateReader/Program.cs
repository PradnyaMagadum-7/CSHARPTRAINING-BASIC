
using Microsoft.Data.SqlClient;
using System.Data;


namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Employee obj = new Employee { EmpNo = 7, EmpName = "Nikhil", Basic = 12345, DeptNo = 30 };
            // singleValue();
            //DataReader();

            //Employee obj2 = GetSingleValueUsingDataReader(1234567);
            DataReader2();

        }

        static void singleValue()
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
            //dataReader and dataset to read the records 
            try
            {
                conn.Open();
                SqlCommand cmdsingleValue = new SqlCommand();
                cmdsingleValue.Connection = conn;
                cmdsingleValue.CommandType = CommandType.Text;  //first choice always be stored procedure // but in some cases you dont have 
               // cmdsingleValue.CommandText = "select count(*) from Employees";
               // cmdsingleValue.CommandText = "select EmpName from Employees where EmpNo = 1";
               cmdsingleValue.CommandText = "select * from Employees"; // here o/p would be 1 bcoz execute Scaller returnd only 1 row and 1 column

                object rtval = cmdsingleValue.ExecuteScalar();  //it returns object and 1 row 1 column
                Console.WriteLine(rtval);
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

        //if we have more than one value to read then we should use dataReader

        static void DataReader()
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
                                                                                                                            //dataReader and dataset to read the records 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;   
                                                                
                cmd.CommandText = "select * from Employees"; 

                SqlDataReader dr = cmd.ExecuteReader();//returns sqldatareader so catched in same
                while(dr.Read()) //DR.READ >> READS ONE ROW AT A TIME
                {
                    Console.WriteLine(dr[0]);  //read in terms of column name or number but name would be better//this returns object
                    Console.WriteLine(dr["EmpNo"]);
                    
                    Console.WriteLine(dr.GetInt32(0));// this returns specific data type
                    Console.WriteLine(dr.GetInt32("EmpNo"));
                    Console.WriteLine();
                }
                dr.Close();
                
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


        static Employee GetSingleValueUsingDataReader(int EmpNo)
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
            Employee emp = null;                                                                                                            //dataReader and dataset to read the records 
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo",EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();//returns sqldatareader so catched in same
                
                if(dr.Read())
                {
                    Console.WriteLine("Found");

                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return emp;
        }

        static void DataReader2()
        {
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
                                                                                                                            //dataReader and dataset to read the records 
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Employees;select * from Departments";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    Console.WriteLine(dr[0]);  
                    Console.WriteLine(dr["EmpNo"]);

                    Console.WriteLine(dr.GetInt32(0));
                    Console.WriteLine(dr.GetInt32("EmpNo"));
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Deps");
                dr.NextResult();//true>> when there is another resultset
                 
                while (dr.Read())
                    {
                        Console.WriteLine(dr.GetInt32(0));
                        Console.WriteLine(dr.GetInt32("EmpNo"));
                        Console.WriteLine();
                    }
                
                dr.Close();

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