using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2.Class;
using Test2.test1DataSetTableAdapters;
using static Test2.test1DataSet;

namespace Test2.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели логин");
                return;
            }
            else
            {
                UsersDataTable num = new UsersTableAdapter().GetDataBy1(textBox1.Text.Trim());
                if(num.Rows.Count != 0)
                {
                    MessageBox.Show("Такой логин уже занят");
                    return;
                }
            }

            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }
            else
            {
                if (textBox2.Text.Length < 6)
                {
                    MessageBox.Show("Пароль меньше 6 символов");
                    return;
                }
                if (textBox2.Text.Length > 6)
                {
                    if (textBox2.Text.ToLower() != textBox2.Text)
                    {
                        if (textBox2.Text.ToUpper() != textBox2.Text)
                        {
                            bool IsDig = false;
                            for (int i = 0; i < textBox2.Text.Length; i++)
                            {
                                if ((textBox2.Text[i] >= 65 && textBox2.Text[i] <= 90) ||
                                    (textBox2.Text[i] >= 97 && textBox2.Text[i] <= 122) ||
                                    (textBox2.Text[i] >= 48 && textBox2.Text[i] <= 57)) 
                                {
                                    if (textBox2.Text[i] >= 48 && textBox2.Text[i] <= 57)
                                    {
                                        IsDig = true;
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(textBox2, "Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                                        "одну буквы в верхнем и нижнем регистре ");
                                    MessageBox.Show("Пароль имеет неверные критерии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            if(!IsDig) // ! = не
                            {
                                errorProvider1.SetError(textBox2, "Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                                    "одну буквы в верхнем и нижнем регистре ");
                                MessageBox.Show("Пароль имеет неверные критерии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                new UsersTableAdapter().InsertQuery(textBox1.Text.Trim(), textBox2.Text.Trim(), "Заказчик", textBox3.Text.Trim());

                                errorProvider1.Clear();
                                MessageBox.Show("Вы зарегистрированны");
                                AppData.OpenFormMain(new Autohorization());

                            }
                        }
                        else
                        {

                            errorProvider1.SetError(textBox2, "Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                                "одну буквы в верхнем и нижнем регистре ");
                            MessageBox.Show("Пароль имеет неверные критерии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {

                        errorProvider1.SetError(textBox2, "Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                            "одну буквы в верхнем и нижнем регистре ");
                        MessageBox.Show("Пароль имеет неверные критерии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {

                    errorProvider1.SetError(textBox2, "Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                        "одну буквы в верхнем и нижнем регистре ");
                    MessageBox.Show("Пароль имеет неверные критерии", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (textBox3.Text.Length == 0)
            {
                
                MessageBox.Show("Вы не ввели наименование");

               

                return;
            }
           
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Пароль должен содержать: минимум 6 символов на английском языке и 1 цифру, " +
                "одну буквы в верхнем и нижнем регистре ","Справка", MessageBoxButtons.OK, MessageBoxIcon.Information ) ;
  
        }
    }
}
