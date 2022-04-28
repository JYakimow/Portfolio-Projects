using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//this program currently does not access the database (which means notes no longer save) because the database is no longer turned on. 
//It was only turned on during the hackathon when we worked on it.

//In this app you can create notes, save them to a database and access them later. You could access the same notes from different computers 
//because the notes are stored in a database in the cloud. as of right now the database is currently turned off. If it was turned on it would work.

//by Jonathan Yakimow, Nick Spreitzer, Jake Loyd, Michael Schweitzer, and Temish Christiansen during a 5 hour "mini hackathon"

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateall();
        }

        public void updateall()
        {
            try
            {
                var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";

                listBox1.Items.Clear();
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("select title from notes", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader.GetString(0));
                            Console.WriteLine(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Font SelectedText_Font = richTextBox1.SelectionFont;
                if (SelectedText_Font != null)
                    richTextBox1.SelectionFont = new Font(SelectedText_Font,
                      SelectedText_Font.Style ^ FontStyle.Italic);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Font SelectedText_Font = richTextBox1.SelectionFont;
                if (SelectedText_Font != null)
                    richTextBox1.SelectionFont = new Font(SelectedText_Font,
                      SelectedText_Font.Style ^ FontStyle.Underline);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Font SelectedText_Font = richTextBox1.SelectionFont;
                if (SelectedText_Font != null)
                    richTextBox1.SelectionFont = new Font(SelectedText_Font,
                      SelectedText_Font.Style ^ FontStyle.Bold);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try 
            {
                var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";
                string title = textBox2.Text;
                string body = richTextBox1.Text;

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = ($"DELETE FROM Notes WHERE title = '{title}'");
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = ("INSERT INTO Notes(title, body) VALUES (@p1, @p2)");
                        cmd.Parameters.AddWithValue("p1", title);
                        cmd.Parameters.AddWithValue("p2", body);
                        cmd.ExecuteNonQuery();

                        updateall();
                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e) //load
        {
            updateall();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";

                string curItem = listBox1.SelectedItem.ToString();
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand($"select * from notes where title = '{curItem}'", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textBox2.Text = reader.GetString(1);
                            richTextBox1.Text = reader.GetString(2);
                            Console.WriteLine(reader.GetString(2));
                        }

                    }



                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try 
            {
                var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";
                string title = textBox2.Text;

                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = ($"DELETE FROM Notes WHERE title = '{title}'");
                        cmd.ExecuteNonQuery();
                        updateall();

                    }
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            richTextBox1.Text = "";
            updateall();
        }
    }
}
