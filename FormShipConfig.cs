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
    public partial class FormShipConfig : Form
    {
        ITransport ship = null;

        public FormShipConfig()
        {
            InitializeComponent();
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                ship.DrawTransport(gr);
                pictureBoxShipConfig.Image = bmp;
            }
        }

        private void labelShipConfig_MouseDown(object sender, MouseEventArgs e)
        {
            labelShipConfig.DoDragDrop(labelShipConfig.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelCruiserConfig_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiserConfig.DoDragDrop(labelCruiserConfig.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShipConfig_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelShipConfig_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный корабль":
                    ship = new Ship(100, 500, Color.Pink);
                    break;
                case "Крейсер":
                    ship = new Cruiser(100, 500, Color.Pink, Color.Purple, true, true, true);
                    break;
            }
            DrawShip();
        }
    }
}
