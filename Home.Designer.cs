using System;

namespace PDSA_Game
{
    partial class Home
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
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.btnGame4 = new System.Windows.Forms.Button();
            this.btnGame5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame1
            // 
            this.btnGame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.Location = new System.Drawing.Point(0, 0);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(784, 100);
            this.btnGame1.TabIndex = 0;
            this.btnGame1.Text = "Game 01";
            this.btnGame1.UseVisualStyleBackColor = true;
            this.btnGame1.Click += new System.EventHandler(this.btnGame1_Click);
            // 
            // btnGame2
            // 
            this.btnGame2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.Location = new System.Drawing.Point(0, 100);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(784, 100);
            this.btnGame2.TabIndex = 1;
            this.btnGame2.Text = "Game 02";
            this.btnGame2.UseVisualStyleBackColor = true;
            this.btnGame2.Click += new System.EventHandler(this.btnGame2_Click);
            // 
            // btnGame3
            // 
            this.btnGame3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.Location = new System.Drawing.Point(0, 200);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(784, 100);
            this.btnGame3.TabIndex = 2;
            this.btnGame3.Text = "Game 03";
            this.btnGame3.UseVisualStyleBackColor = true;
            this.btnGame3.Click += new System.EventHandler(this.btnGame3_Click);
            // 
            // btnGame4
            // 
            this.btnGame4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame4.Location = new System.Drawing.Point(0, 300);
            this.btnGame4.Name = "btnGame4";
            this.btnGame4.Size = new System.Drawing.Size(784, 100);
            this.btnGame4.TabIndex = 3;
            this.btnGame4.Text = "Game 04";
            this.btnGame4.UseVisualStyleBackColor = true;
            this.btnGame4.Click += new System.EventHandler(this.btnGame4_Click);
            // 
            // btnGame5
            // 
            this.btnGame5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame5.Location = new System.Drawing.Point(0, 400);
            this.btnGame5.Name = "btnGame5";
            this.btnGame5.Size = new System.Drawing.Size(784, 100);
            this.btnGame5.TabIndex = 4;
            this.btnGame5.Text = "Game 05";
            this.btnGame5.UseVisualStyleBackColor = true;
            this.btnGame5.Click += new System.EventHandler(this.btnGame5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 499);
            this.Controls.Add(this.btnGame5);
            this.Controls.Add(this.btnGame4);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Button btnGame4;
        private System.Windows.Forms.Button btnGame5;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private EventHandler button3_Click;
        private EventHandler button4_Click;
        private EventHandler button5_Click;
    }
}

