namespace demo
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
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.textBox1 = new System.Windows.Forms.TextBox();
=======
            this.txtb1 = new System.Windows.Forms.TextBox();
>>>>>>> BTH3
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
=======
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(59, 97);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 22);
            this.txtb1.TabIndex = 1;
>>>>>>> BTH3
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
<<<<<<< HEAD
            this.Controls.Add(this.textBox1);
=======
            this.Controls.Add(this.txtb1);
>>>>>>> BTH3
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox textBox1;
=======
        private System.Windows.Forms.TextBox txtb1;
>>>>>>> BTH3
    }
}

