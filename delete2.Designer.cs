namespace train307
{
    partial class delete2
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 245);
            button1.Name = "button1";
            button1.Size = new Size(106, 42);
            button1.TabIndex = 0;
            button1.Text = "Delete Train";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 171);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Train_ID:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 2;
            // 
            // delete2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "delete2";
            Text = "delete2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}