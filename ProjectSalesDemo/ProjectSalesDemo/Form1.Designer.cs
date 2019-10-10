namespace ProjectSalesDemo
{
    partial class Form1
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
            this.btnDelegate = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnLamMethd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnInterface = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(108, 181);
            this.btnDelegate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(75, 71);
            this.btnDelegate.TabIndex = 49;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(438, 119);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Stock number";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(418, 172);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(120, 80);
            this.btnValidate.TabIndex = 46;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(325, 181);
            this.btnLambda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(75, 71);
            this.btnLambda.TabIndex = 41;
            this.btnLambda.Text = "Lambda Calc";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnLamMethd
            // 
            this.btnLamMethd.Location = new System.Drawing.Point(216, 181);
            this.btnLamMethd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMethd.Name = "btnLamMethd";
            this.btnLamMethd.Size = new System.Drawing.Size(75, 71);
            this.btnLamMethd.TabIndex = 40;
            this.btnLamMethd.Text = "Lambda Boolean  Method";
            this.btnLamMethd.UseVisualStyleBackColor = true;
            this.btnLamMethd.Click += new System.EventHandler(this.btnLamMethd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Percent";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(131, 144);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(236, 20);
            this.txtOutput.TabIndex = 38;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(148, 79);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Projected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(148, 18);
            this.txtSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 34;
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(9, 181);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(75, 71);
            this.btnInterface.TabIndex = 52;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 314);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnLamMethd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSales);
            this.Name = "Form1";
            this.Text = "Interface, Delegates, Lambda, String Manipulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnLamMethd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnInterface;
    }
}

