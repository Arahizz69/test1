using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2.Forms
{
    public partial class Direct : Form
    {
        public Direct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Users Users = new Users();
            Users.TopLevel = false; //Отключает отображение как дополнительного окна
            Users.FormBorderStyle = FormBorderStyle.None; //Убирает границы формы (верхнюю панель с кнопками закрыть, свернуть и т.д.)
            Users.Dock = DockStyle.Fill; //Закрепляет форму в панели

            panel1.Controls.Add(Users); //Добавили фрму в панель
            panel1.Tag = Users;

            Users.BringToFront(); //Вывели форму на передний план
            Users.Show(); //Открыли форму
        }

        private void Direct_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
