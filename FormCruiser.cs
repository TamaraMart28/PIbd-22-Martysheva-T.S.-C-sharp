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
        private ITransport ship;
        public FormCruiser()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawCruiser(gr);
            pictureBoxCruiser.Image = bmp;
        }

        private void buttonCreateCruiser_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Cruiser(rnd.Next(100, 150), rnd.Next(1000, 2000), Color.Pink, Color.Purple,
                true, true, true);
            /*cruiser.Init(rnd.Next(100, 150), rnd.Next(1000, 2000), Color.Pink, Color.Purple,
                true, true, true);*/
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100),
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
                    ship.MoveCruiser(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveCruiser(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveCruiser(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveCruiser(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCruiser.Width,
           pictureBoxCruiser.Height);
            Draw();

        }
    }
}
