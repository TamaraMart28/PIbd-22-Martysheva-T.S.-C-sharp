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
    public partial class FormDocking : Form
    {
        private readonly Docking<Ship> docking;

        public FormDocking()
        {
            InitializeComponent();
            docking = new Docking<Ship>(pictureBoxDocking.Width, pictureBoxDocking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDocking.Width, pictureBoxDocking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            docking.Draw(gr);
            pictureBoxDocking.Image = bmp;
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (docking + ship != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Нет свободных доков");
                }
            }
        }

        private void buttonSetCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Cruiser(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    if (docking + ship != -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Нет свободных доков");
                    }
                }
            }
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var ship = docking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (ship != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
