using System;
using NLog;
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
        private readonly Logger logger;

        public FormDocking()
        {
            InitializeComponent();
            dockingCollection = new DockingCollection(pictureBoxDocking.Width, pictureBoxDocking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    var ship = dockingCollection[listBoxDockings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (ship != null)
                    {
                        FormCruiser form = new FormCruiser();
                        form.SetShip(ship);
                        form.ShowDialog();
                        logger.Info($"Изъят корабль {ship} с места { maskedTextBoxPlace.Text} ");
                    }
                    Draw();
                }
                catch (DockingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
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
            logger.Info($"Добавили стоянку доков {textBoxNewDockingStage.Text}");
            dockingCollection.AddDocking(textBoxNewDockingStage.Text);
            ReloadLevels();
        }

        private void buttonDelDocking_Click(object sender, EventArgs e)
        {
            if (listBoxDockings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить стоянку доков { listBoxDockings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили стоянку доков { listBoxDockings.SelectedItem.ToString()} ");
                    dockingCollection.DelDocking(listBoxDockings.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void listBoxDockings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на стоянку доков { listBoxDockings.SelectedItem.ToString()} ");
            Draw();
        }

        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxDockings.SelectedIndex > -1)
            {
                try
                {
                    if ((dockingCollection[listBoxDockings.SelectedItem.ToString()]) + ship != -1)
                    {
                        Draw();
                        logger.Info($"Добавлен корабль {ship}");
                    }
                    else
                    {
                        MessageBox.Show("Корабль не удалось поставить");
                    }
                }
                catch (DockingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
                catch (DockingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogShips.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockingCollection.SaveData(saveFileDialogShips.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialogShips.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogShips.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockingCollection.LoadData(openFileDialogShips.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialogShips.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (DockingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxDockings.SelectedIndex > -1)
            {
                dockingCollection[listBoxDockings.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }

        }
    }
}
