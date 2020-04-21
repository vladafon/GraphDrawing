namespace GraphDrawing
{
    partial class MainForm
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
            this.pointsLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.savePointsButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pointsCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yMaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yMinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsLimitCheckBox
            // 
            this.pointsLimitCheckBox.AutoSize = true;
            this.pointsLimitCheckBox.Location = new System.Drawing.Point(525, 411);
            this.pointsLimitCheckBox.Name = "pointsLimitCheckBox";
            this.pointsLimitCheckBox.Size = new System.Drawing.Size(103, 21);
            this.pointsLimitCheckBox.TabIndex = 0;
            this.pointsLimitCheckBox.Text = "Points limit!!";
            this.pointsLimitCheckBox.UseVisualStyleBackColor = true;
            // 
            // savePointsButton
            // 
            this.savePointsButton.Location = new System.Drawing.Point(876, 401);
            this.savePointsButton.Name = "savePointsButton";
            this.savePointsButton.Size = new System.Drawing.Size(144, 36);
            this.savePointsButton.TabIndex = 1;
            this.savePointsButton.Text = "Save points";
            this.savePointsButton.UseVisualStyleBackColor = true;
            this.savePointsButton.Click += new System.EventHandler(this.savePointsButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 402);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(144, 36);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pointsCountLabel
            // 
            this.pointsCountLabel.AutoSize = true;
            this.pointsCountLabel.Location = new System.Drawing.Point(366, 411);
            this.pointsCountLabel.Name = "pointsCountLabel";
            this.pointsCountLabel.Size = new System.Drawing.Size(16, 17);
            this.pointsCountLabel.TabIndex = 3;
            this.pointsCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "x from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "y from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "to";
            // 
            // xMinNumericUpDown
            // 
            this.xMinNumericUpDown.Location = new System.Drawing.Point(689, 388);
            this.xMinNumericUpDown.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.xMinNumericUpDown.Name = "xMinNumericUpDown";
            this.xMinNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.xMinNumericUpDown.TabIndex = 12;
            // 
            // xMaxNumericUpDown
            // 
            this.xMaxNumericUpDown.Location = new System.Drawing.Point(790, 388);
            this.xMaxNumericUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.xMaxNumericUpDown.Name = "xMaxNumericUpDown";
            this.xMaxNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.xMaxNumericUpDown.TabIndex = 13;
            this.xMaxNumericUpDown.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // yMaxNumericUpDown
            // 
            this.yMaxNumericUpDown.Location = new System.Drawing.Point(790, 426);
            this.yMaxNumericUpDown.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.yMaxNumericUpDown.Name = "yMaxNumericUpDown";
            this.yMaxNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.yMaxNumericUpDown.TabIndex = 16;
            this.yMaxNumericUpDown.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.yMaxNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // yMinNumericUpDown
            // 
            this.yMinNumericUpDown.Location = new System.Drawing.Point(689, 426);
            this.yMinNumericUpDown.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.yMinNumericUpDown.Minimum = new decimal(new int[] {
            1023,
            0,
            0,
            -2147483648});
            this.yMinNumericUpDown.Name = "yMinNumericUpDown";
            this.yMinNumericUpDown.Size = new System.Drawing.Size(63, 22);
            this.yMinNumericUpDown.TabIndex = 15;
            this.yMinNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "to";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 475);
            this.Controls.Add(this.yMaxNumericUpDown);
            this.Controls.Add(this.yMinNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xMaxNumericUpDown);
            this.Controls.Add(this.xMinNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointsCountLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.savePointsButton);
            this.Controls.Add(this.pointsLimitCheckBox);
            this.Name = "MainForm";
            this.Text = "GraphDrawing";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pointsLimitCheckBox;
        private System.Windows.Forms.Button savePointsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label pointsCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown xMinNumericUpDown;
        private System.Windows.Forms.NumericUpDown xMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown yMaxNumericUpDown;
        private System.Windows.Forms.NumericUpDown yMinNumericUpDown;
        private System.Windows.Forms.Label label4;
    }
}

