using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();

            conn_string.Server = "localhost";
            conn_string.UserID = "root";
            conn_string.Password = "";
            conn_string.Database = "cocktails";

            mcon = new MySqlConnection(conn_string.ToString());
        }
        MySqlConnection mcon;
        DataSet ds = new DataSet();
       

        //Обновить
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // dataGridView2.Rows.Clear();
                mcon.Close();
                string reciept = "";

                //reciept  содержит название коктейля
                reciept = listView1.SelectedItems[0].Text;
                MySqlDataAdapter mda = new MySqlDataAdapter("select ingridients from cocktails.drinks where name='" + reciept +"'", mcon);
                mcon.Open();
                mda.Fill(ds, "drinks");
                //dataGridView2.DataSource = ds.Tables["drinks"]; //должно выполняться в фоне

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Поиск
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                mcon.Close();
                MySqlDataAdapter mda = new MySqlDataAdapter("select * from cocktails.drinks", mcon);
                mcon.Open();
                mda.Fill(ds, "drinks");
                dataGridView1.DataSource = ds.Tables["drinks"]; //должно выполняться в фоне
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Добавить
        private void button3_Click(object sender, EventArgs e)
        {
            mcon.Close();
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from cocktails.drinks ", mcon);
            mcon.Open();
            DataTable dt = new DataTable();
            mda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["name"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listView1.Items.Add(listitem);
                
            }
        }
        //Добавить
        private void button4_Click(object sender, EventArgs e)
        {
            mcon.Close();
            string reciept = "";
            
            //reciept  содержит название коктейля
            reciept = listView1.SelectedItems[0].Text;
            MySqlDataAdapter mda = new MySqlDataAdapter("select * from cocktails.drinks", mcon);
            mcon.Open();
            DataTable dt = new DataTable();
            mda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ingridients"].ToString());
                listitem.SubItems.Add(dr["ingridients"].ToString());
                listView2.Items.Add(listitem);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}


