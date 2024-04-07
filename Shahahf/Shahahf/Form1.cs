using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shahahf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string field = textBox1.Text;
            string Operator = textBox2.Text;
            string Value = textBox3.Text;
            string startdate = dateTimePicker1.Value.ToString();
            string enddate = dateTimePicker2.Value.ToString();
            string connstring = "Data Source =desktop-26a4l4j;Initial Catalog=test; Integrated Security=true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            if (startdate == "01/01/2000" || enddate == "01/01/2000")
            {
                if(Operator.Equals(">"))
                {
                    string query1 = "SELECT * FROM DATA WHERE field > Value ";
                    SqlCommand cmnd = new SqlCommand(query1, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("<"))
                {
                    string query2 = "SELECT* FROM DATA WHERE field < Value";
                    SqlCommand cmnd = new SqlCommand(query2, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("="))
                {
                    string query3 = "SELECT * FROM DATA WHERE field = Value";
                    SqlCommand cmnd = new SqlCommand(query3, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("!="))
                {
                    string query4 = "SELECT * FROM DATA WHERE field != Value";
                    SqlCommand cmnd = new SqlCommand(query4, con);
                    cmnd.ExecuteReader();
                }
                

            }
            else
            {
               
                if (Operator.Equals(">"))
                {
                    string query1 = "SELECT* FROM DATA WHERE(DATEDIFF (dd, startdate, Date_Time) > 0) AND(DATEDIFF(dd, Date_Time, enddate) > 0) AND field > Value";
                    SqlCommand cmnd = new SqlCommand(query1, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("<"))
                {
                    string query2 = "SELECT* FROM DATA WHERE(DATEDIFF (dd, startdate, Date_Time) > 0) AND(DATEDIFF(dd, Date_Time, enddate) > 0) AND field < Value";
                    SqlCommand cmnd = new SqlCommand(query2, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("="))
                {
                    string query3 = "SELECT* FROM DATA WHERE(DATEDIFF (dd, startdate, Date_Time) > 0) AND(DATEDIFF(dd, Date_Time, enddate) > 0) AND field = Value";
                    SqlCommand cmnd = new SqlCommand(query3, con);
                    cmnd.ExecuteReader();
                }

                if (Operator.Equals("!="))
                {
                    string query4 = "SELECT* FROM DATA WHERE(DATEDIFF (dd, startdate, Date_Time) > 0) AND(DATEDIFF(dd, Date_Time, enddate) > 0) AND field != Value";
                    SqlCommand cmnd = new SqlCommand(query4, con);
                    cmnd.ExecuteReader();
                }


            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = new DateTime(2000,01,01);
            dateTimePicker2.Value = new DateTime(2000, 01, 01);
        }
    }
}
