namespace train307
{
    partial class Form4
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 240);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Passenger ID:";
            // 
            // button1
            // 
            button1.Location = new Point(339, 433);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 1;
            button1.Text = "Buy ticket";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 229);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 333);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Trip ID:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 323);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(705, 407);
            button2.Name = "button2";
            button2.Size = new Size(117, 81);
            button2.TabIndex = 6;
            button2.Text = "Train System";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
    }
}