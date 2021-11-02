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
        private readonly DockingCollection dockingCollection;

        public FormDocking()
        {
            InitializeComponent();
            dockingCollection = new DockingCollection(pictureBoxDocking.Width, pictureBoxDocking.Height);
        }

        private void ReloadLevels()
        {
            int index = listBoxDockings.SelectedIndex;
            listBoxDockings.Items.Clear();
            for (int i = 0; i < dockingCollection.Keys.Count; i++)
            {
                listBoxDockings.Items.Add(dockingCollection.Keys[i]);
            }
            if (listBoxDockings.Items.Count > 0 && (index == -1 || index >= listBoxDockings.Items.Count))
            {
                listBoxDockings.SelectedIndex = 0;
            }
            else if (listBoxDockings.Items.Count > 0 && index > -1 && index < listBoxDockings.Items.Count)
            {
                listBoxDockings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxDockings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDocking.Width, pictureBoxDocking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockingCollection[listBoxDockings.SelectedItem.ToString()].Draw(gr);
                pictureBoxDocking.Image = bmp;
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBoxDocking.Width, pictureBoxDocking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxDocking.Image = bmp;
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormShipConfig();
            formCarConfig.AddEvent(AddShip);
            formCarConfig.Show();
        }

        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxDockings.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                var ship = dockingCollection[listBoxDockings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (ship != null)
                {
                    FormCruiser form = new FormCruiser();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonAddDocking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewDockingStage.Text))
            {
                MessageBox.Show("Введите название стоянки доков", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockingCollection.AddDocking(textBoxNewDockingStage.Text);
            ReloadLevels();
        }

        private void buttonDelDocking_Click(object sender, EventArgs e)
        {
            if (listBoxDockings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить стоянку доков { listBoxDockings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockingCollection.DelDocking(listBoxDockings.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void listBoxDockings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxDockings.SelectedIndex > -1)
            {
                if ((dockingCollection[listBoxDockings.SelectedItem.ToString()]) + ship != -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Нет свободных доков на стоянке");
                }
            }
        }
    }
}
