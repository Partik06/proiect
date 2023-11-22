
namespace proiect
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
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.Location = new System.Drawing.Point(457, 394);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(259, 52);
            this.b2.TabIndex = 2;
            this.b2.Text = "Wednesday";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.Location = new System.Drawing.Point(67, 395);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(264, 50);
            this.b3.TabIndex = 3;
            this.b3.Text = "You";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(617, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 103);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b1
            // 
            this.b1.BackgroundImage = global::proiect.Properties.Resources.download;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.b1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b1.Location = new System.Drawing.Point(12, 0);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(553, 174);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::proiect.Properties.Resources.netflix_shows_new_seasons_for_2023;
            this.pictureBox1.Location = new System.Drawing.Point(12, 178);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 519);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button button1;
    }
}

