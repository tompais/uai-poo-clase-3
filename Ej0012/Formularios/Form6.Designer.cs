namespace Ejercicios_Clase_3.Ej0012.Formularios
{
    partial class Form6
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            numericUpDown3 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(223, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Carga de Combustible";
            // 
            // button1
            // 
            button1.Location = new Point(178, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 35);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Litros";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(165, 33);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Location = new Point(223, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 131);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Consumo de Combustible";
            // 
            // button2
            // 
            button2.Location = new Point(178, 91);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 35);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "KM";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(165, 33);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 0;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 64);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Velocidad";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(165, 62);
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 3;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private NumericUpDown numericUpDown3;
    }
}