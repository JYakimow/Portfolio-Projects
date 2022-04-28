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

namespace NoteTaker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";
            string title = noteTitle.Text;
            string body = noteBody.Text;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = ("INSERT INTO Notes(title, body) VALUES (@p1, @p2)");
                    cmd.Parameters.AddWithValue("p1", title);
                    cmd.Parameters.AddWithValue("p2", body);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            var connString = "Host=34.68.29.205;Username=postgres;Password=aqiitfhz7l0MLlz6;Database=postgres";

            listBox1.Items.Clear();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("select * from notes", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString(1));
                        Console.WriteLine(reader.GetString(1));
                    }
                }
            }
        }

        private void noteTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
