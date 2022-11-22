using System.Windows.Forms;

namespace FigureFormation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBoxClockwise2 = new System.Windows.Forms.CheckBox();
            this.checkBoxClockwise1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownVelocity2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVelocity1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLength1 = new System.Windows.Forms.NumericUpDown();
            this.labelVelocity2 = new System.Windows.Forms.Label();
            this.labelLength2 = new System.Windows.Forms.Label();
            this.labelVelocity1 = new System.Windows.Forms.Label();
            this.labelLength1 = new System.Windows.Forms.Label();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.numericUpDownEllipse = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEllipse = new System.Windows.Forms.CheckBox();
            this.numericUpDownCircle = new System.Windows.Forms.NumericUpDown();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.buttonLineColor = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 604);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxClockwise2);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxClockwise1);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownVelocity2);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownLength2);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownVelocity1);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownLength1);
            this.splitContainer2.Panel1.Controls.Add(this.labelVelocity2);
            this.splitContainer2.Panel1.Controls.Add(this.labelLength2);
            this.splitContainer2.Panel1.Controls.Add(this.labelVelocity1);
            this.splitContainer2.Panel1.Controls.Add(this.labelLength1);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxRotate);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownEllipse);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxEllipse);
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDownCircle);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxPoints);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxCircle);
            this.splitContainer2.Panel1.Controls.Add(this.labelPoints);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(184, 604);
            this.splitContainer2.SplitterDistance = 520;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // checkBoxClockwise2
            // 
            this.checkBoxClockwise2.AutoSize = true;
            this.checkBoxClockwise2.Enabled = false;
            this.checkBoxClockwise2.Location = new System.Drawing.Point(86, 313);
            this.checkBoxClockwise2.Name = "checkBoxClockwise2";
            this.checkBoxClockwise2.Size = new System.Drawing.Size(74, 17);
            this.checkBoxClockwise2.TabIndex = 23;
            this.checkBoxClockwise2.Text = "Clockwise";
            this.checkBoxClockwise2.UseVisualStyleBackColor = true;
            // 
            // checkBoxClockwise1
            // 
            this.checkBoxClockwise1.AutoSize = true;
            this.checkBoxClockwise1.Enabled = false;
            this.checkBoxClockwise1.Location = new System.Drawing.Point(86, 238);
            this.checkBoxClockwise1.Name = "checkBoxClockwise1";
            this.checkBoxClockwise1.Size = new System.Drawing.Size(74, 17);
            this.checkBoxClockwise1.TabIndex = 22;
            this.checkBoxClockwise1.Text = "Clockwise";
            this.checkBoxClockwise1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownVelocity2
            // 
            this.numericUpDownVelocity2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownVelocity2.Enabled = false;
            this.numericUpDownVelocity2.Location = new System.Drawing.Point(86, 287);
            this.numericUpDownVelocity2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownVelocity2.Name = "numericUpDownVelocity2";
            this.numericUpDownVelocity2.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownVelocity2.TabIndex = 21;
            // 
            // numericUpDownLength2
            // 
            this.numericUpDownLength2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownLength2.Enabled = false;
            this.numericUpDownLength2.Location = new System.Drawing.Point(86, 261);
            this.numericUpDownLength2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownLength2.Name = "numericUpDownLength2";
            this.numericUpDownLength2.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownLength2.TabIndex = 20;
            // 
            // numericUpDownVelocity1
            // 
            this.numericUpDownVelocity1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownVelocity1.Enabled = false;
            this.numericUpDownVelocity1.Location = new System.Drawing.Point(86, 212);
            this.numericUpDownVelocity1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownVelocity1.Name = "numericUpDownVelocity1";
            this.numericUpDownVelocity1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownVelocity1.TabIndex = 19;
            // 
            // numericUpDownLength1
            // 
            this.numericUpDownLength1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownLength1.Enabled = false;
            this.numericUpDownLength1.Location = new System.Drawing.Point(86, 186);
            this.numericUpDownLength1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownLength1.Name = "numericUpDownLength1";
            this.numericUpDownLength1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownLength1.TabIndex = 18;
            // 
            // labelVelocity2
            // 
            this.labelVelocity2.AutoSize = true;
            this.labelVelocity2.Location = new System.Drawing.Point(7, 289);
            this.labelVelocity2.Name = "labelVelocity2";
            this.labelVelocity2.Size = new System.Drawing.Size(53, 13);
            this.labelVelocity2.TabIndex = 17;
            this.labelVelocity2.Text = "Velocity 2";
            // 
            // labelLength2
            // 
            this.labelLength2.AutoSize = true;
            this.labelLength2.Location = new System.Drawing.Point(7, 263);
            this.labelLength2.Name = "labelLength2";
            this.labelLength2.Size = new System.Drawing.Size(49, 13);
            this.labelLength2.TabIndex = 16;
            this.labelLength2.Text = "Length 2";
            // 
            // labelVelocity1
            // 
            this.labelVelocity1.AutoSize = true;
            this.labelVelocity1.Location = new System.Drawing.Point(7, 214);
            this.labelVelocity1.Name = "labelVelocity1";
            this.labelVelocity1.Size = new System.Drawing.Size(53, 13);
            this.labelVelocity1.TabIndex = 15;
            this.labelVelocity1.Text = "Velocity 1";
            // 
            // labelLength1
            // 
            this.labelLength1.AutoSize = true;
            this.labelLength1.Location = new System.Drawing.Point(7, 188);
            this.labelLength1.Name = "labelLength1";
            this.labelLength1.Size = new System.Drawing.Size(49, 13);
            this.labelLength1.TabIndex = 14;
            this.labelLength1.Text = "Length 1";
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(10, 164);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(82, 17);
            this.checkBoxRotate.TabIndex = 13;
            this.checkBoxRotate.Text = "Rotate lines";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.checkBoxRotate_CheckedChanged);
            // 
            // numericUpDownEllipse
            // 
            this.numericUpDownEllipse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownEllipse.Enabled = false;
            this.numericUpDownEllipse.Location = new System.Drawing.Point(86, 109);
            this.numericUpDownEllipse.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownEllipse.Name = "numericUpDownEllipse";
            this.numericUpDownEllipse.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownEllipse.TabIndex = 12;
            // 
            // checkBoxEllipse
            // 
            this.checkBoxEllipse.AutoSize = true;
            this.checkBoxEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEllipse.Enabled = false;
            this.checkBoxEllipse.Location = new System.Drawing.Point(10, 110);
            this.checkBoxEllipse.Name = "checkBoxEllipse";
            this.checkBoxEllipse.Size = new System.Drawing.Size(56, 17);
            this.checkBoxEllipse.TabIndex = 11;
            this.checkBoxEllipse.Text = "Ellipse";
            this.checkBoxEllipse.UseVisualStyleBackColor = true;
            this.checkBoxEllipse.CheckedChanged += new System.EventHandler(this.checkBoxEllipse_CheckedChanged);
            // 
            // numericUpDownCircle
            // 
            this.numericUpDownCircle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownCircle.Enabled = false;
            this.numericUpDownCircle.Location = new System.Drawing.Point(86, 88);
            this.numericUpDownCircle.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownCircle.Name = "numericUpDownCircle";
            this.numericUpDownCircle.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownCircle.TabIndex = 10;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(86, 5);
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoints.Size = new System.Drawing.Size(86, 78);
            this.textBoxPoints.TabIndex = 9;
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCircle.Location = new System.Drawing.Point(10, 88);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(52, 17);
            this.checkBoxCircle.TabIndex = 8;
            this.checkBoxCircle.Text = "Circle";
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.CheckedChanged += new System.EventHandler(this.checkBoxCircle_CheckedChanged);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(10, 8);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(36, 13);
            this.labelPoints.TabIndex = 7;
            this.labelPoints.Text = "Points";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.buttonLineColor);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonDraw);
            this.splitContainer3.Size = new System.Drawing.Size(184, 81);
            this.splitContainer3.SplitterDistance = 83;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // buttonLineColor
            // 
            this.buttonLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLineColor.Location = new System.Drawing.Point(3, 3);
            this.buttonLineColor.Name = "buttonLineColor";
            this.buttonLineColor.Size = new System.Drawing.Size(80, 75);
            this.buttonLineColor.TabIndex = 0;
            this.buttonLineColor.Text = "Color";
            this.buttonLineColor.UseVisualStyleBackColor = true;
            this.buttonLineColor.Click += new System.EventHandler(this.buttonLineColor_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDraw.Location = new System.Drawing.Point(3, 3);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(91, 75);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(879, 598);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircle)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button buttonLineColor;
        private Button buttonDraw;
        private PictureBox pictureBox;
        private NumericUpDown numericUpDownEllipse;
        private CheckBox checkBoxEllipse;
        private NumericUpDown numericUpDownCircle;
        private TextBox textBoxPoints;
        private CheckBox checkBoxCircle;
        private Label labelPoints;
        private ColorDialog colorDialog;
        private CheckBox checkBoxClockwise2;
        private CheckBox checkBoxClockwise1;
        private NumericUpDown numericUpDownVelocity2;
        private NumericUpDown numericUpDownLength2;
        private NumericUpDown numericUpDownVelocity1;
        private NumericUpDown numericUpDownLength1;
        private Label labelVelocity2;
        private Label labelLength2;
        private Label labelVelocity1;
        private Label labelLength1;
        private CheckBox checkBoxRotate;
    }
}