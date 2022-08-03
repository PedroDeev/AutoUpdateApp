namespace AutoUpdateApp
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
            this.label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(120, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 15);
            this.label.TabIndex = 1;
            this.label.Text = "1.0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(270, 137);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label;
        private Button button2;
    }
}