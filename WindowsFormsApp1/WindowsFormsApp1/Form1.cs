﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "admin" && textBox1.Text == "admin")
            {

                
                Form2 f2 = new Form2();
                f2.Show();
                 this.Hide();

            }
             
            else {
                MessageBox.Show("Не правильный логин или пароль ");
                //переход на форму
                //Авторизация
                //закрытие формы
            }
   

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
    }
}
