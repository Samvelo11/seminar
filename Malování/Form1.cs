using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malování
{
    public partial class Form: System.Windows.Forms.Form
    {
       
        private bool isDrawing = false; //urcuje jestli kreslime
        private Point previousPoint; //predchozi pozice mysi
        private Pen brush;
        private Bitmap canvasBitmap;
        public Form() 
        {
            InitializeComponent();

            canvasBitmap = new Bitmap(pictureBox.Width, pictureBox.Height); //platno o velikosti picture boxu
            pictureBox.Image = canvasBitmap;

            brush = new Pen(Color.Black, 5); //nastaveni stetce
            brush.StartCap = brush.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            // Nastavení číselníku tloušťky štětce
            paintScale.Maximum = 99;
            paintScale.Value = 5;
        }

        private void paintBrush_Click(object sender, EventArgs e)
        {
            brush.Color = colorButton.BackColor;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            previousPoint = e.Location;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing) //deje se pokud kreslime
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.DrawLine(brush, previousPoint, e.Location); //nakresli caru
                }

                pictureBox.Invalidate();
                previousPoint = e.Location;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false; //kdzy pustime tlacitko, tak prestane kreslit
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            brush.Color = pictureBox.BackColor; //guma ma stejnou barvu jako pozadi
        }

        private void colorButton_Click(object sender, EventArgs e) //vyvolání vyskakovacího okna na vybirani barev
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                brush.Color = dialog.Color;
                colorButton.BackColor = dialog.Color;
            }
        }

        private void paintScale_ValueChanged(object sender, EventArgs e)
        {
            brush.Width = (float)paintScale.Value; //cislo na škále urcoje velikost stetce
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(canvasBitmap);
            g.Clear(pictureBox.BackColor);
            pictureBox.Invalidate();
        }

        private void saveButton_Click(object sender, EventArgs e) //tento kod jsem si nasel pomoci AI
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG obrázek|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                canvasBitmap.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
