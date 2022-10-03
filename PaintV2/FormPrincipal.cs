using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintV2
{
    public partial class FormPrincipal : Form
    {
        private bool flagPaint = false;
        private bool flagErase = false;
        private Graphics graphicsPanelPaint;
        private float thicknessPen;
        private Color eraserColor;
        private Image imageToSave;
        private Graphics graphicsImageToSave;

        public FormPrincipal()
        {
            InitializeComponent();

            var buttonColor = Color.DarkSlateGray;
            buttonEraser.FlatAppearance.MouseOverBackColor = buttonColor;
            buttonSave.FlatAppearance.MouseOverBackColor = buttonColor;
            buttonClean.FlatAppearance.MouseOverBackColor = buttonColor;

            for (int i = 2; i <= 100; i += 2)
            {
                comboBoxThicknessPen.Items.Add(i);
            }
            comboBoxThicknessPen.Text = "10";
            comboBoxThicknessPen.IntegralHeight = false;
            comboBoxThicknessPen.MaxDropDownItems = 7;

            graphicsPanelPaint = panelPaint.CreateGraphics();
            thicknessPen = float.Parse(comboBoxThicknessPen.Text);
            eraserColor = panelPaint.BackColor;

            imageToSave = new Bitmap(panelPaint.Width, panelPaint.Height);
            graphicsImageToSave = Graphics.FromImage(imageToSave);
            graphicsImageToSave.Clear(panelPaint.BackColor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? All the paint will erase", "Clean paint", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPanelPaint.Clear(Color.White);

                imageToSave = new Bitmap(panelPaint.Width, panelPaint.Height);
                graphicsImageToSave = Graphics.FromImage(imageToSave);
            }
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {

        }

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPenColor_Click_1(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var colorChoosed = colorDialog.ShowDialog();
            
            if (colorChoosed == DialogResult.OK)
            {
                buttonPenColor.BackColor = colorDialog.Color;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            flagPaint = true;
        }

        private void panelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            flagPaint = false;
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPaint)
            {
                if (!flagErase)
                {
                    graphicsPanelPaint.DrawEllipse(new Pen(buttonPenColor.BackColor, thicknessPen), new RectangleF(e.X, e.Y, thicknessPen, thicknessPen));
                    graphicsImageToSave.DrawEllipse(new Pen(buttonPenColor.BackColor, thicknessPen), new RectangleF(e.X, e.Y, thicknessPen, thicknessPen));
                }
                else
                {
                    graphicsPanelPaint.DrawRectangle(new Pen(eraserColor, thicknessPen), new Rectangle(e.X, e.Y, (int)thicknessPen, (int)thicknessPen));
                    graphicsImageToSave.DrawRectangle(new Pen(eraserColor, thicknessPen), new Rectangle(e.X, e.Y, (int)thicknessPen, (int)thicknessPen));
                }
            }
        }

        private void comboBoxThicknessPen_SelectedIndexChanged(object sender, EventArgs e)
        {
            thicknessPen = float.Parse(comboBoxThicknessPen.SelectedItem.ToString());
        }

        private void buttonEraser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    eraserColor = colorDialog.Color;
                }
            }
            else
            {
                if (!flagErase)
                {
                    flagErase = true;
                    buttonEraser.BackColor = eraserColor;
                }
                else
                {
                    flagErase = false;
                    buttonEraser.BackColor = Color.Black;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imageToSave.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imageToSave.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void panelPaint_Resize(object sender, EventArgs e)
        {
            graphicsPanelPaint = panelPaint.CreateGraphics();
            var imageTemporary = new Bitmap(panelPaint.Width, panelPaint.Height);
            var graphicsImageTemp = Graphics.FromImage(imageTemporary);
            graphicsImageTemp.Clear(panelPaint.BackColor);
            graphicsImageTemp.DrawImage(imageToSave, 0, 0);
            imageToSave = imageTemporary;
            graphicsImageToSave = graphicsImageTemp;
        }
    }
}
