using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCruiser
{
    public partial class FormCruiser : Form
    {
        private Cruiser cruiser;
        public FormCruiser()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Graphics gr = Graphics.FromImage(bmp);
            cruiser.DrawCruiser(gr);
            pictureBoxCruiser.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cruiser = new Cruiser();
            cruiser.Init(rnd.Next(100, 150), rnd.Next(1000, 2000), Color.Pink, Color.Purple,
                true, true, true);
            cruiser.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100),
                pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    cruiser.MoveCruiser(Direction.Up);
                    break;
                case "buttonDown":
                    cruiser.MoveCruiser(Direction.Down);
                    break;
                case "buttonLeft":
                    cruiser.MoveCruiser(Direction.Left);
                    break;
                case "buttonRight":
                    cruiser.MoveCruiser(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
