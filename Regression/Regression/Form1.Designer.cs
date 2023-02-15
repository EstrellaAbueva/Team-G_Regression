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
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Neck";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Abdomen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thigh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forearm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wrist";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(144, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "BODY FAT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // fAge
            // 
            this.fAge.Location = new System.Drawing.Point(125, 88);
            this.fAge.Name = "fAge";
            this.fAge.Size = new System.Drawing.Size(214, 23);
            this.fAge.TabIndex = 8;
            // 
            // fWeight
            // 
            this.fWeight.Location = new System.Drawing.Point(125, 114);
            this.fWeight.Name = "fWeight";
            this.fWeight.Size = new System.Drawing.Size(214, 23);
            this.fWeight.TabIndex = 9;
            // 
            // fNeck
            // 
            this.fNeck.Location = new System.Drawing.Point(125, 143);
            this.fNeck.Name = "fNeck";
            this.fNeck.Size = new System.Drawing.Size(214, 23);
            this.fNeck.TabIndex = 10;
            // 
            // fAbdomen
            // 
            this.fAbdomen.Location = new System.Drawing.Point(125, 172);
            this.fAbdomen.Name = "fAbdomen";
            this.fAbdomen.Size = new System.Drawing.Size(214, 23);
            this.fAbdomen.TabIndex = 11;
            // 
            // fThigh
            // 
            this.fThigh.Location = new System.Drawing.Point(125, 201);
            this.fThigh.Name = "fThigh";
            this.fThigh.Size = new System.Drawing.Size(214, 23);
            this.fThigh.TabIndex = 12;
            // 
            // fForearm
            // 
            this.fForearm.Location = new System.Drawing.Point(125, 230);
            this.fForearm.Name = "fForearm";
            this.fForearm.Size = new System.Drawing.Size(214, 23);
            this.fForearm.TabIndex = 13;
            // 
            // fWrist
            // 
            this.fWrist.Location = new System.Drawing.Point(125, 259);
            this.fWrist.Name = "fWrist";
            this.fWrist.Size = new System.Drawing.Size(214, 23);
            this.fWrist.TabIndex = 14;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(235, 297);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(123, 42);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(235, 345);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(123, 42);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 416);
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
            this.Name = "Form1";
            this.Text = "Team-G Regression";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Button Calculate;
        private Button Clear;
    }
}