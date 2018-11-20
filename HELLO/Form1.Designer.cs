namespace HELLO
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
            this.txtBxname = new System.Windows.Forms.TextBox();
            this.txtbxname2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "HELLO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxname
            // 
            this.txtBxname.Location = new System.Drawing.Point(170, 147);
            this.txtBxname.Name = "txtBxname";
            this.txtBxname.Size = new System.Drawing.Size(100, 20);
            this.txtBxname.TabIndex = 1;
            // 
            // txtbxname2
            // 
            this.txtbxname2.Location = new System.Drawing.Point(314, 228);
            this.txtbxname2.Name = "txtbxname2";
            this.txtbxname2.Size = new System.Drawing.Size(100, 20);
            this.txtbxname2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 693);
            this.Controls.Add(this.txtbxname2);
            this.Controls.Add(this.txtBxname);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBxname;
        private System.Windows.Forms.TextBox txtbxname2;
    }
}

