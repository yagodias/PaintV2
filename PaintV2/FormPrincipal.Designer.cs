namespace PaintV2
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxThicknessPen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPenColor = new System.Windows.Forms.Button();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonClean);
            this.groupBox1.Controls.Add(this.buttonEraser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxThicknessPen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonPenColor);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customize";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Black;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(659, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 32);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.Black;
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Location = new System.Drawing.Point(578, 30);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 32);
            this.buttonClean.TabIndex = 5;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.Black;
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraser.Location = new System.Drawing.Point(497, 30);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(75, 32);
            this.buttonEraser.TabIndex = 4;
            this.buttonEraser.Text = "Eraser";
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pen thickness";
            // 
            // comboBoxThicknessPen
            // 
            this.comboBoxThicknessPen.FormattingEnabled = true;
            this.comboBoxThicknessPen.Location = new System.Drawing.Point(354, 34);
            this.comboBoxThicknessPen.Name = "comboBoxThicknessPen";
            this.comboBoxThicknessPen.Size = new System.Drawing.Size(102, 26);
            this.comboBoxThicknessPen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pen color";
            // 
            // buttonPenColor
            // 
            this.buttonPenColor.BackColor = System.Drawing.Color.Blue;
            this.buttonPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPenColor.Location = new System.Drawing.Point(121, 30);
            this.buttonPenColor.Name = "buttonPenColor";
            this.buttonPenColor.Size = new System.Drawing.Size(75, 32);
            this.buttonPenColor.TabIndex = 0;
            this.buttonPenColor.UseVisualStyleBackColor = false;
            this.buttonPenColor.Click += new System.EventHandler(this.buttonPenColor_Click_1);
            // 
            // panelPaint
            // 
            this.panelPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPaint.BackColor = System.Drawing.Color.White;
            this.panelPaint.Location = new System.Drawing.Point(12, 103);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(776, 335);
            this.panelPaint.TabIndex = 1;
            this.panelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPaint_Paint);
            this.panelPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseDown);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            this.panelPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseUp);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Paint V2";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxThicknessPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPenColor;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelPaint;
    }
}

