
namespace WindowsFormsCruiser
{
    partial class FormShipConfig
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxGun = new System.Windows.Forms.CheckBox();
            this.checkBoxRadar = new System.Windows.Forms.CheckBox();
            this.checkBoxHelipad = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxShipConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxShipType = new System.Windows.Forms.GroupBox();
            this.labelCruiserConfig = new System.Windows.Forms.Label();
            this.labelShipConfig = new System.Windows.Forms.Label();
            this.panelShipConfig = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorDarkBlue = new System.Windows.Forms.Panel();
            this.panelColorOrange = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipConfig)).BeginInit();
            this.groupBoxShipType.SuspendLayout();
            this.panelShipConfig.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxGun);
            this.groupBoxOptions.Controls.Add(this.checkBoxRadar);
            this.groupBoxOptions.Controls.Add(this.checkBoxHelipad);
            this.groupBoxOptions.Controls.Add(this.numericUpDownWeight);
            this.groupBoxOptions.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxOptions.Controls.Add(this.labelWeight);
            this.groupBoxOptions.Controls.Add(this.labelMaxSpeed);
            this.groupBoxOptions.Location = new System.Drawing.Point(21, 213);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(284, 193);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Параметры";
            // 
            // checkBoxGun
            // 
            this.checkBoxGun.AutoSize = true;
            this.checkBoxGun.Location = new System.Drawing.Point(103, 161);
            this.checkBoxGun.Name = "checkBoxGun";
            this.checkBoxGun.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGun.TabIndex = 6;
            this.checkBoxGun.Text = "Пушка";
            this.checkBoxGun.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(105, 127);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRadar.TabIndex = 5;
            this.checkBoxRadar.Text = "Радар";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelipad
            // 
            this.checkBoxHelipad.AutoSize = true;
            this.checkBoxHelipad.Location = new System.Drawing.Point(66, 91);
            this.checkBoxHelipad.Name = "checkBoxHelipad";
            this.checkBoxHelipad.Size = new System.Drawing.Size(145, 17);
            this.checkBoxHelipad.TabIndex = 4;
            this.checkBoxHelipad.Text = "Вертолетная площадка";
            this.checkBoxHelipad.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(149, 55);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(149, 29);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(39, 57);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(74, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес корабля:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 31);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(137, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость:";
            // 
            // pictureBoxShipConfig
            // 
            this.pictureBoxShipConfig.Location = new System.Drawing.Point(22, 20);
            this.pictureBoxShipConfig.Name = "pictureBoxShipConfig";
            this.pictureBoxShipConfig.Size = new System.Drawing.Size(233, 134);
            this.pictureBoxShipConfig.TabIndex = 1;
            this.pictureBoxShipConfig.TabStop = false;
            // 
            // groupBoxShipType
            // 
            this.groupBoxShipType.Controls.Add(this.labelCruiserConfig);
            this.groupBoxShipType.Controls.Add(this.labelShipConfig);
            this.groupBoxShipType.Location = new System.Drawing.Point(21, 31);
            this.groupBoxShipType.Name = "groupBoxShipType";
            this.groupBoxShipType.Size = new System.Drawing.Size(275, 114);
            this.groupBoxShipType.TabIndex = 2;
            this.groupBoxShipType.TabStop = false;
            this.groupBoxShipType.Text = "Тип корабля";
            // 
            // labelCruiserConfig
            // 
            this.labelCruiserConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCruiserConfig.Location = new System.Drawing.Point(94, 67);
            this.labelCruiserConfig.Name = "labelCruiserConfig";
            this.labelCruiserConfig.Size = new System.Drawing.Size(100, 23);
            this.labelCruiserConfig.TabIndex = 1;
            this.labelCruiserConfig.Text = "Крейсер";
            this.labelCruiserConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCruiserConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiserConfig_MouseDown);
            // 
            // labelShipConfig
            // 
            this.labelShipConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShipConfig.Location = new System.Drawing.Point(94, 32);
            this.labelShipConfig.Name = "labelShipConfig";
            this.labelShipConfig.Size = new System.Drawing.Size(100, 23);
            this.labelShipConfig.TabIndex = 0;
            this.labelShipConfig.Text = "Военный корабль";
            this.labelShipConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShipConfig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShipConfig_MouseDown);
            // 
            // panelShipConfig
            // 
            this.panelShipConfig.AllowDrop = true;
            this.panelShipConfig.Controls.Add(this.pictureBoxShipConfig);
            this.panelShipConfig.Location = new System.Drawing.Point(335, 31);
            this.panelShipConfig.Name = "panelShipConfig";
            this.panelShipConfig.Size = new System.Drawing.Size(274, 173);
            this.panelShipConfig.TabIndex = 3;
            this.panelShipConfig.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShipConfig_DragDrop);
            this.panelShipConfig.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShipConfig_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelColorWhite);
            this.groupBoxColors.Controls.Add(this.panelColorOrange);
            this.groupBoxColors.Controls.Add(this.panelColorDarkBlue);
            this.groupBoxColors.Controls.Add(this.panelColorRed);
            this.groupBoxColors.Controls.Add(this.panelColorYellow);
            this.groupBoxColors.Controls.Add(this.panelColorBlue);
            this.groupBoxColors.Controls.Add(this.panelColorGreen);
            this.groupBoxColors.Controls.Add(this.panelColorBlack);
            this.groupBoxColors.Location = new System.Drawing.Point(335, 230);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(274, 176);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.Location = new System.Drawing.Point(32, 74);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlack.TabIndex = 0;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.panelColorGreen.Location = new System.Drawing.Point(91, 74);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(30, 30);
            this.panelColorGreen.TabIndex = 1;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Turquoise;
            this.panelColorBlue.Location = new System.Drawing.Point(150, 74);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlue.TabIndex = 2;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.Location = new System.Drawing.Point(210, 74);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(30, 30);
            this.panelColorYellow.TabIndex = 3;
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.Location = new System.Drawing.Point(32, 122);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(30, 30);
            this.panelColorRed.TabIndex = 4;
            // 
            // panelColorDarkBlue
            // 
            this.panelColorDarkBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorDarkBlue.Location = new System.Drawing.Point(91, 122);
            this.panelColorDarkBlue.Name = "panelColorDarkBlue";
            this.panelColorDarkBlue.Size = new System.Drawing.Size(30, 30);
            this.panelColorDarkBlue.TabIndex = 5;
            // 
            // panelColorOrange
            // 
            this.panelColorOrange.BackColor = System.Drawing.Color.Orange;
            this.panelColorOrange.Location = new System.Drawing.Point(150, 122);
            this.panelColorOrange.Name = "panelColorOrange";
            this.panelColorOrange.Size = new System.Drawing.Size(30, 30);
            this.panelColorOrange.TabIndex = 6;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.Color.Snow;
            this.panelColorWhite.Location = new System.Drawing.Point(210, 122);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(30, 30);
            this.panelColorWhite.TabIndex = 7;
            // 
            // labelMainColor
            // 
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(32, 30);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 8;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDopColor
            // 
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(140, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 23);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп-ый цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShipConfig);
            this.Controls.Add(this.groupBoxShipType);
            this.Controls.Add(this.groupBoxOptions);
            this.Name = "FormShipConfig";
            this.Text = "Создание корабля";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipConfig)).EndInit();
            this.groupBoxShipType.ResumeLayout(false);
            this.panelShipConfig.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxHelipad;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxRadar;
        private System.Windows.Forms.CheckBox checkBoxGun;
        private System.Windows.Forms.PictureBox pictureBoxShipConfig;
        private System.Windows.Forms.GroupBox groupBoxShipType;
        private System.Windows.Forms.Label labelCruiserConfig;
        private System.Windows.Forms.Label labelShipConfig;
        private System.Windows.Forms.Panel panelShipConfig;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorOrange;
        private System.Windows.Forms.Panel panelColorDarkBlue;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorBlack;
    }
}