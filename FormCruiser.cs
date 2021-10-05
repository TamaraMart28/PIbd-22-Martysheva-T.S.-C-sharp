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

        public void SetShip(ITransport ship)
        {
            this.ship = ship;
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTransports.Width, pictureBoxTransports.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship?.DrawTransport(gr);
            pictureBoxTransports.Image = bmp;
        }

        private void buttonCreateCruiser_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Cruiser(rnd.Next(100, 150) + 100, rnd.Next(1000, 2000) + 100, Color.Pink, Color.Purple,
                true, true, true);
            ship.SetPosition(rnd.Next(100, 200), rnd.Next(100, 200),
                pictureBoxTransports.Width, pictureBoxTransports.Height);
            Draw();
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 300) + 100, rnd.Next(1000, 2000) + 100, Color.Pink);
            ship.SetPosition(rnd.Next(100, 200), rnd.Next(100, 200), pictureBoxTransports.Width,
           pictureBoxTransports.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
