namespace ML2
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
            btnTrain = new Button();
            Retrain = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(71, 12);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(150, 46);
            btnTrain.TabIndex = 0;
            btnTrain.Text = "Train";
            btnTrain.UseVisualStyleBackColor = true;
            btnTrain.Click += button1_Click;
            // 
            // Retrain
            // 
            Retrain.Location = new Point(605, 69);
            Retrain.Name = "Retrain";
            Retrain.Size = new Size(150, 46);
            Retrain.TabIndex = 1;
            Retrain.Text = "Re-train";
            Retrain.UseVisualStyleBackColor = true;
            Retrain.Click += Retrain_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Retrain);
            Controls.Add(btnTrain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrain;
        private Button Retrain;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
