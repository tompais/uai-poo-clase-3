﻿namespace Ejercicios_Clase_3
{
    partial class MasterForm
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(135, 47);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 0;
            button1.Text = "Ej0005";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(135, 96);
            button2.Name = "button2";
            button2.Size = new Size(98, 43);
            button2.TabIndex = 1;
            button2.Text = "Ej0006";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(135, 145);
            button3.Name = "button3";
            button3.Size = new Size(98, 43);
            button3.TabIndex = 2;
            button3.Text = "Ej0007";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(135, 194);
            button4.Name = "button4";
            button4.Size = new Size(98, 43);
            button4.TabIndex = 3;
            button4.Text = "Ej0009";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(135, 243);
            button5.Name = "button5";
            button5.Size = new Size(98, 43);
            button5.TabIndex = 4;
            button5.Text = "Ej0010";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 307);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MasterForm";
            Text = "MasterForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}