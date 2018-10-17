using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            FbConnection fbConn = new FbConnection();

            cs.DataSource = "localhost"; // имя компьютера, на котором находится база данных 
            cs.UserID = "SYSDBA"; // имя пользователя, который может производить манипуляции с базой
            cs.Password = "masterkey"; // паоль пользователя, который может производить манипуляции с базой
            cs.Database = "C:/Users/artem/Desktop/Library-master (2)/Library-master/DBLB1.FDB"; // путь к файлу базы данных
            cs.Port = 3050; // порт подключения к базе
            cs.Charset = "win1251"; // кодировка символов
            string ConnString = cs.ToString();

            fbConn.ConnectionString = ConnString;
            fbConn.Open();


            DataTable dt = new DataTable();
            FbDataAdapter da = new FbDataAdapter();
            FbCommand cmd = new FbCommand("select * from NEW_TABLE", fbConn);
            cmd.CommandType = CommandType.Text;
            FbDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            fbConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       //я пишу какие-нибудь комментарии
        }
    }
}
