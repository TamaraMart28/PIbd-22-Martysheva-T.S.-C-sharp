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
        Vehicle ship = null;
        private event Action<Vehicle> eventAddShip;

        public FormShipConfig()
        {
            InitializeComponent();
            panelBlackColor.MouseDown += panelColorAll_MouseDown;
            panelGreenColor.MouseDown += panelColorAll_MouseDown;
            panelBlueColor.MouseDown += panelColorAll_MouseDown;
            panelYellowColor.MouseDown += panelColorAll_MouseDown;
            panelRedColor.MouseDown += panelColorAll_MouseDown;
            panelDarkBlueColor.MouseDown += panelColorAll_MouseDown;
            panelOrangeColor.MouseDown += panelColorAll_MouseDown;
            panelWhiteColor.MouseDown += panelColorAll_MouseDown;
            buttonCancelConfig.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(49, 42, pictureBoxShipConfig.Width, pictureBoxShipConfig.Height);
                ship.DrawTransport(gr);
                pictureBoxShipConfig.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

        private void labelShipConfig_MouseDown(object sender, MouseEventArgs e)
        {
            labelShipConfig.DoDragDrop(labelShipConfig.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelCruiserConfig_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiserConfig.DoDragDrop(labelCruiserConfig.Name, DragDropEffects.Move | DragDropEffects.Copy);
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
                case "labelShipConfig":
                    ship = new Ship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Pink);
                    break;
                case "labelCruiserConfig":
                    ship = new Cruiser((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Pink, Color.Purple, 
                        checkBoxHelipad.Checked, checkBoxRadar.Checked, checkBoxGun.Checked);
                    break;
            }
            DrawShip();
        }

        private void panelColorAll_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null && ship is Cruiser)
            {
                (ship as Cruiser).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();               
            }
        }

        private void buttonAddShipConfig_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();
        }
    }
}
