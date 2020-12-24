namespace Lightyears
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.lightText = new System.Windows.Forms.TextBox();
            this.kmText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(64, 49);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(145, 23);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Calculate In Kilometers";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // lightText
            // 
            this.lightText.Location = new System.Drawing.Point(12, 23);
            this.lightText.Name = "lightText";
            this.lightText.Size = new System.Drawing.Size(260, 20);
            this.lightText.TabIndex = 1;
            // 
            // kmText
            // 
            this.kmText.Location = new System.Drawing.Point(12, 78);
            this.kmText.Name = "kmText";
            this.kmText.Size = new System.Drawing.Size(260, 20);
            this.kmText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LightYears";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kmText);
            this.Controls.Add(this.lightText);
            this.Controls.Add(this.CalcBtn);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "LightYears Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox lightText;
        private System.Windows.Forms.TextBox kmText;
        private System.Windows.Forms.Label label1;
    }
}

