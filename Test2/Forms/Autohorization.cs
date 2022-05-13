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
    public partial class Autohorization : Form
    {
        public Autohorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели логин");
                    return;
            }
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели пароль");
                    return;
            }

            //[тип данных] [название переменной]
            string roll = "";


            UsersDataTable dataTable = new UsersTableAdapter().GetDataBy2(textBox2.Text.Trim(), textBox1.Text.Trim());

            if (dataTable.Rows.Count != 0)
            {
                foreach (UsersRow row in dataTable.Rows)
                {
                    roll = row.Roll;
                    break;
                }

                if (roll == "Директор")
                {
                    AppData.OpenFormMain(new Direct());
                }else if (roll == "Заказчик")
                {
                    AppData.OpenFormMain(new Zakaz());
                }else if (roll == "Менеджер")
                {
                    AppData.OpenFormMain(new Manager());
                }else if (roll == "Кладовщик")
                {
                    AppData.OpenFormMain(new Prikop());
                }
                    
            }
            else

            {    
                MessageBox.Show("Вы ввели неверный логин или пароль");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppData.OpenFormMain(new RegForm());
        }
    }
}
