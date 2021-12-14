
namespace WindowsFormsCruiser
{
    partial class FormDocking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDocking = new System.Windows.Forms.PictureBox();
            this.groupBoxDocking = new System.Windows.Forms.GroupBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxDockings = new System.Windows.Forms.ListBox();
            this.labelDocks = new System.Windows.Forms.Label();
            this.textBoxNewDockingStage = new System.Windows.Forms.TextBox();
            this.buttonAddDocking = new System.Windows.Forms.Button();
            this.buttonDelDocking = new System.Windows.Forms.Button();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogShips = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogShips = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocking)).BeginInit();
            this.groupBoxDocking.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDocking
            // 
            this.pictureBoxDocking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDocking.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxDocking.Name = "pictureBoxDocking";
            this.pictureBoxDocking.Size = new System.Drawing.Size(705, 438);
            this.pictureBoxDocking.TabIndex = 0;
            this.pictureBoxDocking.TabStop = false;
            // 
            // groupBoxDocking
            // 
            this.groupBoxDocking.Controls.Add(this.buttonTakeShip);
            this.groupBoxDocking.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxDocking.Controls.Add(this.labelPlace);
            this.groupBoxDocking.Location = new System.Drawing.Point(711, 81);
            this.groupBoxDocking.Name = "groupBoxDocking";
            this.groupBoxDocking.Size = new System.Drawing.Size(168, 100);
            this.groupBoxDocking.TabIndex = 3;
            this.groupBoxDocking.TabStop = false;
            this.groupBoxDocking.Text = "Забрать корабль";
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(48, 65);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeShip.TabIndex = 2;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(75, 28);
            this.maskedTextBoxPlace.Mask = "00";
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(30, 31);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // listBoxDockings
            // 
            this.listBoxDockings.FormattingEnabled = true;
            this.listBoxDockings.Location = new System.Drawing.Point(714, 316);
            this.listBoxDockings.Name = "listBoxDockings";
            this.listBoxDockings.Size = new System.Drawing.Size(165, 134);
            this.listBoxDockings.TabIndex = 4;
            this.listBoxDockings.SelectedIndexChanged += new System.EventHandler(this.listBoxDockings_SelectedIndexChanged);
            // 
            // labelDocks
            // 
            this.labelDocks.AutoSize = true;
            this.labelDocks.Location = new System.Drawing.Point(741, 184);
            this.labelDocks.Name = "labelDocks";
            this.labelDocks.Size = new System.Drawing.Size(99, 13);
            this.labelDocks.TabIndex = 5;
            this.labelDocks.Text = "Стоянка с доками";
            // 
            // textBoxNewDockingStage
            // 
            this.textBoxNewDockingStage.Location = new System.Drawing.Point(714, 200);
            this.textBoxNewDockingStage.Name = "textBoxNewDockingStage";
            this.textBoxNewDockingStage.Size = new System.Drawing.Size(165, 20);
            this.textBoxNewDockingStage.TabIndex = 6;
            // 
            // buttonAddDocking
            // 
            this.buttonAddDocking.Location = new System.Drawing.Point(714, 226);
            this.buttonAddDocking.Name = "buttonAddDocking";
            this.buttonAddDocking.Size = new System.Drawing.Size(161, 23);
            this.buttonAddDocking.TabIndex = 7;
            this.buttonAddDocking.Text = "Добавить стоянку с доками";
            this.buttonAddDocking.UseVisualStyleBackColor = true;
            this.buttonAddDocking.Click += new System.EventHandler(this.buttonAddDocking_Click);
            // 
            // buttonDelDocking
            // 
            this.buttonDelDocking.Location = new System.Drawing.Point(714, 255);
            this.buttonDelDocking.Name = "buttonDelDocking";
            this.buttonDelDocking.Size = new System.Drawing.Size(161, 23);
            this.buttonDelDocking.TabIndex = 8;
            this.buttonDelDocking.Text = "Удалить стоянку с доками";
            this.buttonDelDocking.UseVisualStyleBackColor = true;
            this.buttonDelDocking.Click += new System.EventHandler(this.buttonDelDocking_Click);
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(739, 23);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(117, 31);
            this.buttonSetShip.TabIndex = 9;
            this.buttonSetShip.Text = "Добавить корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialogShips
            // 
            this.saveFileDialogShips.Filter = "txt file | *.txt";
            // 
            // openFileDialogShips
            // 
            this.openFileDialogShips.FileName = "openFileDialog1";
            this.openFileDialogShips.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(714, 287);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(158, 23);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormDocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.buttonDelDocking);
            this.Controls.Add(this.buttonAddDocking);
            this.Controls.Add(this.textBoxNewDockingStage);
            this.Controls.Add(this.labelDocks);
            this.Controls.Add(this.listBoxDockings);
            this.Controls.Add(this.groupBoxDocking);
            this.Controls.Add(this.pictureBoxDocking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDocking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocking)).EndInit();
            this.groupBoxDocking.ResumeLayout(false);
            this.groupBoxDocking.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocking;
        private System.Windows.Forms.GroupBox groupBoxDocking;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxDockings;
        private System.Windows.Forms.Label labelDocks;
        private System.Windows.Forms.TextBox textBoxNewDockingStage;
        private System.Windows.Forms.Button buttonAddDocking;
        private System.Windows.Forms.Button buttonDelDocking;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogShips;
        private System.Windows.Forms.OpenFileDialog openFileDialogShips;
        private System.Windows.Forms.Button buttonSort;
    }
}