namespace TestDB
{
    partial class WelcomeForm
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
            this.button1Logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Aboard! you are login successfully.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1Logout
            // 
            this.button1Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Logout.Location = new System.Drawing.Point(632, 501);
            this.button1Logout.Name = "button1Logout";
            this.button1Logout.Size = new System.Drawing.Size(167, 41);
            this.button1Logout.TabIndex = 1;
            this.button1Logout.Text = "Logout";
            this.button1Logout.UseVisualStyleBackColor = false;
            this.button1Logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "©2022 Developed by Krishna Gupta Batch:19";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestDB.Properties.Resources.Jiwaji_University_logo;
            this.ClientSize = new System.Drawing.Size(903, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1Logout);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Logout;
        private System.Windows.Forms.Label label2;
    }
}