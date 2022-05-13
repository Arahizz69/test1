using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2.Class
{
   public class AppData
    {
        public static Panel Panel;

        public static void OpenFormMain(Form Mama)
        {
            Mama.TopLevel = false; //Отключает отображение как дополнительного окна
            Mama.FormBorderStyle = FormBorderStyle.None; //Убирает границы формы (верхнюю панель с кнопками закрыть, свернуть и т.д.)
            Mama.Dock = DockStyle.Fill; //Закрепляет форму в панели

            Panel.Controls.Add(Mama); //Добавили фрму в панель
            Panel.Tag = Mama;

            Mama.BringToFront(); //Вывели форму на передний план
            Mama.Show(); //Открыли форму
        }


    }
}
