namespace Regression.Sample
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest1Expected = new System.Windows.Forms.TextBox();
            this.grpTest1 = new System.Windows.Forms.GroupBox();
            this.txtTest1Actual = new System.Windows.Forms.TextBox();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTest1YVector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest1Order = new System.Windows.Forms.TextBox();
            this.txtTest1XVector = new System.Windows.Forms.TextBox();
            this.grpTest2 = new System.Windows.Forms.GroupBox();
            this.txtTest2Actual = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTest2YVector = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTest2Order = new System.Windows.Forms.TextBox();
            this.txtTest2XVector = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTest2Expected = new System.Windows.Forms.TextBox();
            this.grpTest1.SuspendLayout();
            this.grpTest2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expected:";
            // 
            // txtTest1Expected
            // 
            this.txtTest1Expected.ForeColor = System.Drawing.Color.White;
            this.txtTest1Expected.Location = new System.Drawing.Point(12, 162);
            this.txtTest1Expected.Name = "txtTest1Expected";
            this.txtTest1Expected.ReadOnly = true;
            this.txtTest1Expected.Size = new System.Drawing.Size(447, 20);
            this.txtTest1Expected.TabIndex = 1;
            this.txtTest1Expected.TabStop = false;
            this.txtTest1Expected.Text = "y = -3.20151861432345E-05x² + -0.00903173609348595x + 30.3454732801454";
            // 
            // grpTest1
            // 
            this.grpTest1.Controls.Add(this.txtTest1Actual);
            this.grpTest1.Controls.Add(this.btnTest1);
            this.grpTest1.Controls.Add(this.label2);
            this.grpTest1.Controls.Add(this.label4);
            this.grpTest1.Controls.Add(this.txtTest1YVector);
            this.grpTest1.Controls.Add(this.label5);
            this.grpTest1.Controls.Add(this.label3);
            this.grpTest1.Controls.Add(this.txtTest1Order);
            this.grpTest1.Controls.Add(this.txtTest1XVector);
            this.grpTest1.Controls.Add(this.label1);
            this.grpTest1.Controls.Add(this.txtTest1Expected);
            this.grpTest1.Location = new System.Drawing.Point(12, 12);
            this.grpTest1.Name = "grpTest1";
            this.grpTest1.Size = new System.Drawing.Size(708, 282);
            this.grpTest1.TabIndex = 0;
            this.grpTest1.TabStop = false;
            this.grpTest1.Text = "Can Generate Equations";
            // 
            // txtTest1Actual
            // 
            this.txtTest1Actual.BackColor = System.Drawing.Color.Black;
            this.txtTest1Actual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest1Actual.ForeColor = System.Drawing.Color.Yellow;
            this.txtTest1Actual.Location = new System.Drawing.Point(12, 222);
            this.txtTest1Actual.Multiline = true;
            this.txtTest1Actual.Name = "txtTest1Actual";
            this.txtTest1Actual.Size = new System.Drawing.Size(687, 54);
            this.txtTest1Actual.TabIndex = 2;
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(548, 16);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(151, 71);
            this.btnTest1.TabIndex = 1;
            this.btnTest1.Text = "Test";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.RunTest1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "y Vector:";
            // 
            // txtTest1YVector
            // 
            this.txtTest1YVector.ForeColor = System.Drawing.Color.White;
            this.txtTest1YVector.Location = new System.Drawing.Point(12, 82);
            this.txtTest1YVector.Name = "txtTest1YVector";
            this.txtTest1YVector.ReadOnly = true;
            this.txtTest1YVector.Size = new System.Drawing.Size(191, 20);
            this.txtTest1YVector.TabIndex = 1;
            this.txtTest1YVector.TabStop = false;
            this.txtTest1YVector.Text = "29.05, 27.41, 24.27, 21.73, 17.79";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "x Vector:";
            // 
            // txtTest1Order
            // 
            this.txtTest1Order.ForeColor = System.Drawing.Color.White;
            this.txtTest1Order.Location = new System.Drawing.Point(12, 122);
            this.txtTest1Order.Name = "txtTest1Order";
            this.txtTest1Order.ReadOnly = true;
            this.txtTest1Order.Size = new System.Drawing.Size(46, 20);
            this.txtTest1Order.TabIndex = 1;
            this.txtTest1Order.TabStop = false;
            this.txtTest1Order.Text = "2";
            // 
            // txtTest1XVector
            // 
            this.txtTest1XVector.ForeColor = System.Drawing.Color.White;
            this.txtTest1XVector.Location = new System.Drawing.Point(12, 42);
            this.txtTest1XVector.Name = "txtTest1XVector";
            this.txtTest1XVector.ReadOnly = true;
            this.txtTest1XVector.Size = new System.Drawing.Size(191, 20);
            this.txtTest1XVector.TabIndex = 1;
            this.txtTest1XVector.TabStop = false;
            this.txtTest1XVector.Text = "100, 205, 305, 402, 500";
            // 
            // grpTest2
            // 
            this.grpTest2.Controls.Add(this.txtTest2Actual);
            this.grpTest2.Controls.Add(this.txtTest2);
            this.grpTest2.Controls.Add(this.label6);
            this.grpTest2.Controls.Add(this.label7);
            this.grpTest2.Controls.Add(this.txtTest2YVector);
            this.grpTest2.Controls.Add(this.label8);
            this.grpTest2.Controls.Add(this.label9);
            this.grpTest2.Controls.Add(this.txtTest2Order);
            this.grpTest2.Controls.Add(this.txtTest2XVector);
            this.grpTest2.Controls.Add(this.label10);
            this.grpTest2.Controls.Add(this.txtTest2Expected);
            this.grpTest2.Location = new System.Drawing.Point(11, 326);
            this.grpTest2.Name = "grpTest2";
            this.grpTest2.Size = new System.Drawing.Size(708, 282);
            this.grpTest2.TabIndex = 1;
            this.grpTest2.TabStop = false;
            this.grpTest2.Text = "Can Solve Equations";
            // 
            // txtTest2Actual
            // 
            this.txtTest2Actual.BackColor = System.Drawing.Color.Black;
            this.txtTest2Actual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest2Actual.ForeColor = System.Drawing.Color.Yellow;
            this.txtTest2Actual.Location = new System.Drawing.Point(12, 222);
            this.txtTest2Actual.Multiline = true;
            this.txtTest2Actual.Name = "txtTest2Actual";
            this.txtTest2Actual.Size = new System.Drawing.Size(687, 54);
            this.txtTest2Actual.TabIndex = 1;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(548, 16);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(151, 71);
            this.txtTest2.TabIndex = 0;
            this.txtTest2.Text = "Test";
            this.txtTest2.UseVisualStyleBackColor = true;
            this.txtTest2.Click += new System.EventHandler(this.RunTest2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Actual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "y Vector:";
            // 
            // txtTest2YVector
            // 
            this.txtTest2YVector.ForeColor = System.Drawing.Color.White;
            this.txtTest2YVector.Location = new System.Drawing.Point(12, 82);
            this.txtTest2YVector.Name = "txtTest2YVector";
            this.txtTest2YVector.ReadOnly = true;
            this.txtTest2YVector.Size = new System.Drawing.Size(191, 20);
            this.txtTest2YVector.TabIndex = 1;
            this.txtTest2YVector.TabStop = false;
            this.txtTest2YVector.Text = "29.05, 27.41, 24.27, 21.73, 17.79";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Order:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "x Vector:";
            // 
            // txtTest2Order
            // 
            this.txtTest2Order.ForeColor = System.Drawing.Color.White;
            this.txtTest2Order.Location = new System.Drawing.Point(12, 122);
            this.txtTest2Order.Name = "txtTest2Order";
            this.txtTest2Order.ReadOnly = true;
            this.txtTest2Order.Size = new System.Drawing.Size(46, 20);
            this.txtTest2Order.TabIndex = 1;
            this.txtTest2Order.TabStop = false;
            this.txtTest2Order.Text = "2";
            // 
            // txtTest2XVector
            // 
            this.txtTest2XVector.ForeColor = System.Drawing.Color.White;
            this.txtTest2XVector.Location = new System.Drawing.Point(12, 42);
            this.txtTest2XVector.Name = "txtTest2XVector";
            this.txtTest2XVector.ReadOnly = true;
            this.txtTest2XVector.Size = new System.Drawing.Size(191, 20);
            this.txtTest2XVector.TabIndex = 1;
            this.txtTest2XVector.TabStop = false;
            this.txtTest2XVector.Text = "100, 205, 305, 402, 500";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Expected:";
            // 
            // txtTest2Expected
            // 
            this.txtTest2Expected.ForeColor = System.Drawing.Color.White;
            this.txtTest2Expected.Location = new System.Drawing.Point(12, 162);
            this.txtTest2Expected.Name = "txtTest2Expected";
            this.txtTest2Expected.ReadOnly = true;
            this.txtTest2Expected.Size = new System.Drawing.Size(191, 20);
            this.txtTest2Expected.TabIndex = 1;
            this.txtTest2Expected.TabStop = false;
            this.txtTest2Expected.Text = "27.1485291833113";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 611);
            this.Controls.Add(this.grpTest2);
            this.Controls.Add(this.grpTest1);
            this.Name = "Form1";
            this.Text = "Regression.Sample";
            this.grpTest1.ResumeLayout(false);
            this.grpTest1.PerformLayout();
            this.grpTest2.ResumeLayout(false);
            this.grpTest2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest1Expected;
        private System.Windows.Forms.GroupBox grpTest1;
        private System.Windows.Forms.TextBox txtTest1Actual;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTest1YVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest1Order;
        private System.Windows.Forms.TextBox txtTest1XVector;
        private System.Windows.Forms.GroupBox grpTest2;
        private System.Windows.Forms.TextBox txtTest2Actual;
        private System.Windows.Forms.Button txtTest2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTest2YVector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTest2Order;
        private System.Windows.Forms.TextBox txtTest2XVector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTest2Expected;
    }
}

