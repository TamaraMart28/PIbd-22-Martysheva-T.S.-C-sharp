
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
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.buttonSetCruiser = new System.Windows.Forms.Button();
            this.groupBoxDocking = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocking)).BeginInit();
            this.groupBoxDocking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDocking
            // 
            this.pictureBoxDocking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDocking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDocking.Name = "pictureBoxDocking";
            this.pictureBoxDocking.Size = new System.Drawing.Size(705, 462);
            this.pictureBoxDocking.TabIndex = 0;
            this.pictureBoxDocking.TabStop = false;
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(735, 12);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(121, 23);
            this.buttonSetShip.TabIndex = 1;
            this.buttonSetShip.Text = "Швартовка корабля";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            // 
            // buttonSetCruiser
            // 
            this.buttonSetCruiser.Location = new System.Drawing.Point(726, 56);
            this.buttonSetCruiser.Name = "buttonSetCruiser";
            this.buttonSetCruiser.Size = new System.Drawing.Size(137, 23);
            this.buttonSetCruiser.TabIndex = 2;
            this.buttonSetCruiser.Text = "Швартовка крейсера";
            this.buttonSetCruiser.UseVisualStyleBackColor = true;
            // 
            // groupBoxDocking
            // 
            this.groupBoxDocking.Controls.Add(this.buttonTakeShip);
            this.groupBoxDocking.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxDocking.Controls.Add(this.labelPlace);
            this.groupBoxDocking.Location = new System.Drawing.Point(711, 106);
            this.groupBoxDocking.Name = "groupBoxDocking";
            this.groupBoxDocking.Size = new System.Drawing.Size(168, 100);
            this.groupBoxDocking.TabIndex = 3;
            this.groupBoxDocking.TabStop = false;
            this.groupBoxDocking.Text = "Забрать корабль";
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
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(75, 28);
            this.maskedTextBoxPlace.Mask = "00";
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(70, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(48, 65);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeShip.TabIndex = 2;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            // 
            // FormDocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.groupBoxDocking);
            this.Controls.Add(this.buttonSetCruiser);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.pictureBoxDocking);
            this.Name = "FormDocking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDocking)).EndInit();
            this.groupBoxDocking.ResumeLayout(false);
            this.groupBoxDocking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDocking;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Button buttonSetCruiser;
        private System.Windows.Forms.GroupBox groupBoxDocking;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
    }
}