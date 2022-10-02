using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private Graphics graphicsPanelPaint;
        private float thicknessPen;

        public FormPrincipal()
        {
            InitializeComponent();

            for (int i = 2; i <= 100; i += 2)
            {
                comboBoxThicknessPen.Items.Add(i);
            }
            comboBoxThicknessPen.Text = "10";
            comboBoxThicknessPen.IntegralHeight = false;
            comboBoxThicknessPen.MaxDropDownItems = 7;

            graphicsPanelPaint = panelPaint.CreateGraphics();
            thicknessPen = float.Parse(comboBoxThicknessPen.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? All the paint will erase", "Clean paint", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                graphicsPanelPaint.Clear(Color.White);
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
                graphicsPanelPaint.DrawEllipse(new Pen(buttonPenColor.BackColor, thicknessPen), new RectangleF(e.X, e.Y, thicknessPen, thicknessPen));
            }
        }
    }
}
