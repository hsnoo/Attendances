using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;

namespace Attendance
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form1()
        {
            InitializeComponent();
            server = "";
            database = "";
            uid = "";
            password = "";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
            DTP_DT.Value = new DateTime(DateTime.UtcNow.Ticks);
        }

        private void BTN_Select_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string dt = DTP_DT.Value.ToString("yyyy-MM-dd");
                string name = TB_NAME.Text;

                string sql = $"select * from tgatelog where funm = '{name}' and fevttm like '{dt}%' order by fevttm desc ";

                MySqlCommand cmd = null;

                cmd = new MySqlCommand(sql, connection);

                MySqlDataReader reader = null;

                connection.Open();

                if (cmd != null)
                {
                    reader = cmd.ExecuteReader();
                }
                else
                {
                    throw new InvalidOperationException("Command object is null.");
                }

                dataGridView1.Rows.Clear();

                if (TB_NAME != null)
                {
                    while (reader.Read())
                    {
                        string fevttm = reader.IsDBNull(reader.GetOrdinal("fevttm")) ? null : reader.GetString("fevttm");
                        string funm = reader.IsDBNull(reader.GetOrdinal("funm")) ? null : reader.GetString("funm");
                        string fpartnm2 = reader.IsDBNull(reader.GetOrdinal("fpartnm2")) ? null : reader.GetString("fpartnm2");
                        string ipaddr = reader.IsDBNull(reader.GetOrdinal("ipaddr")) ? null : reader.GetString("ipaddr");

                        if (ipaddr == "172.16.254.71")
                        {
                            ipaddr = "2층 입구";
                        }
                        else if(ipaddr == "172.16.254.207")
                        {
                            ipaddr = "3층 입구";
                        }
                        else if(ipaddr == "172.16.254.82")
                        {
                            ipaddr = "4층 입구";
                        }
                        else if (ipaddr == "172.16.254.205")
                        {
                            ipaddr = "지하 입구";
                        }
                        else
                        {
                            MessageBox.Show("등록되지 않은 단말기");
                        }


                        dataGridView1.Rows.Add(fevttm, funm, fpartnm2, ipaddr);
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("이름을 입력해주세요.");
                }
            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TB_NAME.Text = "";
            DTP_DT.Value = new DateTime(DateTime.UtcNow.Ticks);
        }
    }
}
