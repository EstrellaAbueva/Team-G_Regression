namespace Regression
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fAge = new System.Windows.Forms.TextBox();
            this.fWeight = new System.Windows.Forms.TextBox();
            this.fNeck = new System.Windows.Forms.TextBox();
            this.fAbdomen = new System.Windows.Forms.TextBox();
            this.fThigh = new System.Windows.Forms.TextBox();
            this.fForearm = new System.Windows.Forms.TextBox();
            this.fWrist = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bfCount = new System.Windows.Forms.Label();
            this.titleBackground = new System.Windows.Forms.PictureBox();
            this.dividerColor = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight      (lbs)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Neck         (cm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Abdomen  (cm)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thigh        (cm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forearm    (cm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wrist        (cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkViolet;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Body Fat Prediction";
            // 
            // fAge
            // 
            this.fAge.Location = new System.Drawing.Point(212, 130);
            this.fAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fAge.Name = "fAge";
            this.fAge.Size = new System.Drawing.Size(124, 27);
            this.fAge.TabIndex = 8;
            // 
            // fWeight
            // 
            this.fWeight.Location = new System.Drawing.Point(212, 165);
            this.fWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fWeight.Name = "fWeight";
            this.fWeight.Size = new System.Drawing.Size(124, 27);
            this.fWeight.TabIndex = 9;
            // 
            // fNeck
            // 
            this.fNeck.Location = new System.Drawing.Point(212, 200);
            this.fNeck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fNeck.Name = "fNeck";
            this.fNeck.Size = new System.Drawing.Size(124, 27);
            this.fNeck.TabIndex = 10;
            // 
            // fAbdomen
            // 
            this.fAbdomen.Location = new System.Drawing.Point(212, 235);
            this.fAbdomen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fAbdomen.Name = "fAbdomen";
            this.fAbdomen.Size = new System.Drawing.Size(124, 27);
            this.fAbdomen.TabIndex = 11;
            // 
            // fThigh
            // 
            this.fThigh.Location = new System.Drawing.Point(212, 270);
            this.fThigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fThigh.Name = "fThigh";
            this.fThigh.Size = new System.Drawing.Size(124, 27);
            this.fThigh.TabIndex = 12;
            // 
            // fForearm
            // 
            this.fForearm.Location = new System.Drawing.Point(212, 305);
            this.fForearm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fForearm.Name = "fForearm";
            this.fForearm.Size = new System.Drawing.Size(124, 27);
            this.fForearm.TabIndex = 13;
            // 
            // fWrist
            // 
            this.fWrist.Location = new System.Drawing.Point(212, 340);
            this.fWrist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fWrist.Name = "fWrist";
            this.fWrist.Size = new System.Drawing.Size(124, 27);
            this.fWrist.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(48, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Body Fat:";
            // 
            // bfCount
            // 
            this.bfCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bfCount.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bfCount.Location = new System.Drawing.Point(53, 448);
            this.bfCount.Name = "bfCount";
            this.bfCount.Size = new System.Drawing.Size(161, 32);
            this.bfCount.TabIndex = 18;
            this.bfCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBackground
            // 
            this.titleBackground.BackColor = System.Drawing.Color.DarkViolet;
            this.titleBackground.Location = new System.Drawing.Point(-25, -24);
            this.titleBackground.Name = "titleBackground";
            this.titleBackground.Size = new System.Drawing.Size(437, 120);
            this.titleBackground.TabIndex = 19;
            this.titleBackground.TabStop = false;
            // 
            // dividerColor
            // 
            this.dividerColor.BackColor = System.Drawing.Color.DarkViolet;
            this.dividerColor.Location = new System.Drawing.Point(12, 383);
            this.dividerColor.Name = "dividerColor";
            this.dividerColor.Size = new System.Drawing.Size(368, 5);
            this.dividerColor.TabIndex = 20;
            this.dividerColor.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(237, 446);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(99, 40);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(237, 404);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(99, 40);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 502);
            this.Controls.Add(this.dividerColor);
            this.Controls.Add(this.bfCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.fWrist);
            this.Controls.Add(this.fForearm);
            this.Controls.Add(this.fThigh);
            this.Controls.Add(this.fAbdomen);
            this.Controls.Add(this.fNeck);
            this.Controls.Add(this.fWeight);
            this.Controls.Add(this.fAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Team-G Regression";
            ((System.ComponentModel.ISupportInitialize)(this.titleBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividerColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox fAge;
        private TextBox fWeight;
        private TextBox fNeck;
        private TextBox fAbdomen;
        private TextBox fThigh;
        private TextBox fForearm;
        private TextBox fWrist;
        private Label label9;
        private Label bfCount;
        private PictureBox titleBackground;
        private PictureBox dividerColor;
        private Button Clear;
        private Button Calculate;
    }
}