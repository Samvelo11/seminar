namespace Malování
{
    partial class Form
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.paintBrush = new System.Windows.Forms.PictureBox();
            this.eraser = new System.Windows.Forms.PictureBox();
            this.colorButton = new System.Windows.Forms.PictureBox();
            this.paintScale = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintScale)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.Gray;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(785, 56);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 59);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(785, 459);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // paintBrush
            // 
            this.paintBrush.BackColor = System.Drawing.Color.Gray;
            this.paintBrush.ErrorImage = null;
            this.paintBrush.Image = ((System.Drawing.Image)(resources.GetObject("paintBrush.Image")));
            this.paintBrush.InitialImage = null;
            this.paintBrush.Location = new System.Drawing.Point(12, 3);
            this.paintBrush.Name = "paintBrush";
            this.paintBrush.Size = new System.Drawing.Size(50, 50);
            this.paintBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paintBrush.TabIndex = 3;
            this.paintBrush.TabStop = false;
            this.paintBrush.Click += new System.EventHandler(this.paintBrush_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.Gray;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.Location = new System.Drawing.Point(103, 3);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(50, 50);
            this.eraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eraser.TabIndex = 4;
            this.eraser.TabStop = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorButton.Location = new System.Drawing.Point(194, 3);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(50, 50);
            this.colorButton.TabIndex = 5;
            this.colorButton.TabStop = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // paintScale
            // 
            this.paintScale.Location = new System.Drawing.Point(326, 21);
            this.paintScale.Name = "paintScale";
            this.paintScale.Size = new System.Drawing.Size(72, 20);
            this.paintScale.TabIndex = 6;
            this.paintScale.ValueChanged += new System.EventHandler(this.paintScale_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(521, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Uložit";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(630, 21);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 23);
            this.eraseButton.TabIndex = 8;
            this.eraseButton.Text = "Smazat";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 517);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paintScale);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.paintBrush);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form";
            this.Text = "Malovani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintScale)).EndInit();
            this.ResumeLayout(false);

        }

      

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox paintBrush;
        private System.Windows.Forms.PictureBox eraser;
        private System.Windows.Forms.PictureBox colorButton;
        private System.Windows.Forms.NumericUpDown paintScale;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button eraseButton;
    }
}

