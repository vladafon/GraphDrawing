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
            this.savePointsButton.Location = new System.Drawing.Point(634, 402);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1801, 450);
            this.Controls.Add(this.pointsCountLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.savePointsButton);
            this.Controls.Add(this.pointsLimitCheckBox);
            this.Name = "MainForm";
            this.Text = "GraphDrawing";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pointsLimitCheckBox;
        private System.Windows.Forms.Button savePointsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label pointsCountLabel;
    }
}

