
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
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelWhiteColor = new System.Windows.Forms.Panel();
            this.panelOrangeColor = new System.Windows.Forms.Panel();
            this.panelDarkBlueColor = new System.Windows.Forms.Panel();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.panelBlueColor = new System.Windows.Forms.Panel();
            this.panelGreenColor = new System.Windows.Forms.Panel();
            this.panelBlackColor = new System.Windows.Forms.Panel();
            this.buttonAddShipConfig = new System.Windows.Forms.Button();
            this.buttonCancelConfig = new System.Windows.Forms.Button();
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
            this.groupBoxOptions.Location = new System.Drawing.Point(21, 12);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(284, 173);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Параметры";
            // 
            // checkBoxGun
            // 
            this.checkBoxGun.AutoSize = true;
            this.checkBoxGun.Location = new System.Drawing.Point(101, 145);
            this.checkBoxGun.Name = "checkBoxGun";
            this.checkBoxGun.Size = new System.Drawing.Size(59, 17);
            this.checkBoxGun.TabIndex = 6;
            this.checkBoxGun.Text = "Пушка";
            this.checkBoxGun.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadar
            // 
            this.checkBoxRadar.AutoSize = true;
            this.checkBoxRadar.Location = new System.Drawing.Point(103, 112);
            this.checkBoxRadar.Name = "checkBoxRadar";
            this.checkBoxRadar.Size = new System.Drawing.Size(57, 17);
            this.checkBoxRadar.TabIndex = 5;
            this.checkBoxRadar.Text = "Радар";
            this.checkBoxRadar.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelipad
            // 
            this.checkBoxHelipad.AutoSize = true;
            this.checkBoxHelipad.Location = new System.Drawing.Point(65, 81);
            this.checkBoxHelipad.Name = "checkBoxHelipad";
            this.checkBoxHelipad.Size = new System.Drawing.Size(145, 17);
            this.checkBoxHelipad.TabIndex = 4;
            this.checkBoxHelipad.Text = "Вертолетная площадка";
            this.checkBoxHelipad.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(149, 46);
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
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(149, 20);
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
            this.labelWeight.Location = new System.Drawing.Point(36, 48);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(74, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес корабля:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 20);
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
            this.groupBoxShipType.Location = new System.Drawing.Point(335, 214);
            this.groupBoxShipType.Name = "groupBoxShipType";
            this.groupBoxShipType.Size = new System.Drawing.Size(284, 104);
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
            this.panelShipConfig.Location = new System.Drawing.Point(335, 12);
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
            this.groupBoxColors.Controls.Add(this.panelWhiteColor);
            this.groupBoxColors.Controls.Add(this.panelOrangeColor);
            this.groupBoxColors.Controls.Add(this.panelDarkBlueColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Controls.Add(this.panelBlueColor);
            this.groupBoxColors.Controls.Add(this.panelGreenColor);
            this.groupBoxColors.Controls.Add(this.panelBlackColor);
            this.groupBoxColors.Location = new System.Drawing.Point(21, 214);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(284, 176);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(140, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 23);
            this.labelDopColor.TabIndex = 9;
            this.labelDopColor.Text = "Доп-ый цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(32, 30);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 8;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelWhiteColor
            // 
            this.panelWhiteColor.BackColor = System.Drawing.Color.Snow;
            this.panelWhiteColor.Location = new System.Drawing.Point(210, 122);
            this.panelWhiteColor.Name = "panelWhiteColor";
            this.panelWhiteColor.Size = new System.Drawing.Size(30, 30);
            this.panelWhiteColor.TabIndex = 7;
            // 
            // panelOrangeColor
            // 
            this.panelOrangeColor.BackColor = System.Drawing.Color.Orange;
            this.panelOrangeColor.Location = new System.Drawing.Point(150, 122);
            this.panelOrangeColor.Name = "panelOrangeColor";
            this.panelOrangeColor.Size = new System.Drawing.Size(30, 30);
            this.panelOrangeColor.TabIndex = 6;
            // 
            // panelDarkBlueColor
            // 
            this.panelDarkBlueColor.BackColor = System.Drawing.Color.Blue;
            this.panelDarkBlueColor.Location = new System.Drawing.Point(91, 122);
            this.panelDarkBlueColor.Name = "panelDarkBlueColor";
            this.panelDarkBlueColor.Size = new System.Drawing.Size(30, 30);
            this.panelDarkBlueColor.TabIndex = 5;
            // 
            // panelRedColor
            // 
            this.panelRedColor.BackColor = System.Drawing.Color.Red;
            this.panelRedColor.Location = new System.Drawing.Point(32, 122);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(30, 30);
            this.panelRedColor.TabIndex = 4;
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.panelYellowColor.Location = new System.Drawing.Point(210, 74);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(30, 30);
            this.panelYellowColor.TabIndex = 3;
            // 
            // panelBlueColor
            // 
            this.panelBlueColor.BackColor = System.Drawing.Color.Turquoise;
            this.panelBlueColor.Location = new System.Drawing.Point(150, 74);
            this.panelBlueColor.Name = "panelBlueColor";
            this.panelBlueColor.Size = new System.Drawing.Size(30, 30);
            this.panelBlueColor.TabIndex = 2;
            // 
            // panelGreenColor
            // 
            this.panelGreenColor.BackColor = System.Drawing.Color.LimeGreen;
            this.panelGreenColor.Location = new System.Drawing.Point(91, 74);
            this.panelGreenColor.Name = "panelGreenColor";
            this.panelGreenColor.Size = new System.Drawing.Size(30, 30);
            this.panelGreenColor.TabIndex = 1;
            // 
            // panelBlackColor
            // 
            this.panelBlackColor.BackColor = System.Drawing.Color.Black;
            this.panelBlackColor.Location = new System.Drawing.Point(32, 74);
            this.panelBlackColor.Name = "panelBlackColor";
            this.panelBlackColor.Size = new System.Drawing.Size(30, 30);
            this.panelBlackColor.TabIndex = 0;
            // 
            // buttonAddShipConfig
            // 
            this.buttonAddShipConfig.Location = new System.Drawing.Point(357, 336);
            this.buttonAddShipConfig.Name = "buttonAddShipConfig";
            this.buttonAddShipConfig.Size = new System.Drawing.Size(90, 38);
            this.buttonAddShipConfig.TabIndex = 5;
            this.buttonAddShipConfig.Text = "Добавить";
            this.buttonAddShipConfig.UseVisualStyleBackColor = true;
            this.buttonAddShipConfig.Click += new System.EventHandler(this.buttonAddShipConfig_Click);
            // 
            // buttonCancelConfig
            // 
            this.buttonCancelConfig.Location = new System.Drawing.Point(500, 336);
            this.buttonCancelConfig.Name = "buttonCancelConfig";
            this.buttonCancelConfig.Size = new System.Drawing.Size(90, 38);
            this.buttonCancelConfig.TabIndex = 6;
            this.buttonCancelConfig.Text = "Отмена";
            this.buttonCancelConfig.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 401);
            this.Controls.Add(this.buttonCancelConfig);
            this.Controls.Add(this.groupBoxShipType);
            this.Controls.Add(this.buttonAddShipConfig);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShipConfig);
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
        private System.Windows.Forms.Panel panelWhiteColor;
        private System.Windows.Forms.Panel panelOrangeColor;
        private System.Windows.Forms.Panel panelDarkBlueColor;
        private System.Windows.Forms.Panel panelRedColor;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Panel panelBlueColor;
        private System.Windows.Forms.Panel panelGreenColor;
        private System.Windows.Forms.Panel panelBlackColor;
        private System.Windows.Forms.Button buttonAddShipConfig;
        private System.Windows.Forms.Button buttonCancelConfig;
    }
}