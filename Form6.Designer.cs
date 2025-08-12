namespace train307
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 115);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Train number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 166);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Trip_ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 223);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "No.normalsteats:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 271);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "No.VIPSeats:";
            // 
            // button5
            // 
            button5.Location = new Point(189, 379);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Insert";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(368, 379);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 11;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(571, 379);
            button7.Name = "button7";
            button7.Size = new Size(79, 23);
            button7.TabIndex = 12;
            button7.Text = "Delet Form";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(298, 12);
            button8.Name = "button8";
            button8.Size = new Size(207, 46);
            button8.TabIndex = 13;
            button8.Text = "Trains Mangment";
            button8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(343, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(343, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 17;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}