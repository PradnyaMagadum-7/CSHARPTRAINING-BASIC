using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONNECTION
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
                                                                                                                            //dataReader and dataset to read the records 
            try
            {
                conn.Open();
                //COMMAND
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;


                SqlDataAdapter da = new SqlDataAdapter(); //IT has 4 commands and here we are using select for fill and during update we will use another 3
                //dataset
                da.SelectCommand = cmd;

                //Dataset>> disconnected , updatable and xml set of records
                //while working with dataset we dont neet our connection to be opned and we can mannually make updates too but not reflected in databses    
                //no contsrin
                ds = new DataSet();

                cmd.CommandText = "select * from Employees";
                da.Fill(ds, "Emps");  //emps is a dataset table name

                cmd.CommandText = "select * from Departments";
                da.Fill(ds, "Deps");  //emps is a dataset table name

                //primary key constraints
                DataColumn[] arrCols = new DataColumn[1];  //why 1 >>> bcoz primary key >> for composite primary key it will be 2
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];   //primary key of that perticular table
                ds.Tables["Emps"].PrimaryKey = arrCols; //(arrCols>>>>Array of data columns)

                //Foreign key constraints
                ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"],    //Parent column ///master table is department as it has one to many relation
                    ds.Tables["Emps"].Columns["DeptNo"]);   //chlid column

                //column level constraint 
                ds.Tables["Deps"].Columns["DeptName"].Unique = true;

                //dataGridView1.DataSource = ds.Tables["Emps"];
                dataGridView1.DataSource = ds.Tables["Deps"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            //CONNECTION
            SqlConnection conn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=june23;Integrated Security=True;"; //data source is the name of the sql server 
                                                                                                                            // //integrated security >> windows auth // paid version has userid and pass
                                                                                                                            //dataReader and dataset to read the records 
            try
            {
                conn.Open();
                //COMMAND
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(); //IT has 4 commands and here we are using select for fill and during update we will use another 3

                da.UpdateCommand = cmdUpdate;
                //da.InsertCommand = cmdInsert;
                //da.DeleteCommand = cmdDelete;

                da.Update(ds, "Emps");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}