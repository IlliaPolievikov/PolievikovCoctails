﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter mda = new MySqlDataAdapter("select * from cocktails.drinks", mcon);
                mcon.Open();
                mda.Fill(ds, "drikns");
                //dataGridView1.DataSource = ds.Tables["ingridients"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                mcon.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter("select id from cocktails.users where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", mcon);
                DataTable dt = new System.Data.DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    string query = "";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        query = dr["id"].ToString();
                    }
                    if (query == "1")
                    {
                        this.Hide();
                        Form2 s2 = new Form2();
                        s2.Show();
                    }
                    else
                    {
                        this.Hide();
                        Form3 s3 = new Form3();
                        s3.Show();
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mcon.Close();
            }
        }
        //listBox1.Items.Add(n);
    }
}
