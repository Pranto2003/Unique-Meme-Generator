﻿namespace MemeGenerator
{
    partial class Meme2
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 184, 148);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(680, 23);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 0;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Meme2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._417756073_1461562017902937_2004775775759846309_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Meme2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meme2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}