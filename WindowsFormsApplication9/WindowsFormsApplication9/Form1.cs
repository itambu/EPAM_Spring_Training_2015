using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication9.BlogDataSetTableAdapters;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 //           SqlConnection connection = new SqlConnection(@"Server=Tambu-PC\SQLEXPRESS; initial catalog=BLOG; Integrated Security=True");
 //           connection.Open();

            BlogDataSet dataSet = new BlogDataSet();
            UserSetTableAdapter userAdapter = new UserSetTableAdapter();
            userAdapter.Fill(dataSet.UserSet);
            
            userAdapter.Insert("Tom");
            userAdapter.Update(dataSet);

            //SqlCommand command = 
            //    new SqlCommand(@"SELECT * FROM UserSet Where UserSet.UserName=@pname", connection);
            //SqlParameter param = new SqlParameter("@pname", "John");
            //command.Parameters.Add(param);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    int id = reader.GetInt32(0);
            //    string name = reader.GetString(1);
            //}

            //reader.Dispose();
//            connection.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'blogDataSet.UserSet' table. You can move, or remove it, as needed.
            this.userSetTableAdapter.Fill(this.blogDataSet.UserSet);

        }
    }
}
