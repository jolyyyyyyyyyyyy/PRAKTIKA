namespace tattoo1
{
    partial class Сustomers
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 103);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 1;
            label2.Text = "Регистрация клиента";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(81, 158);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 2;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(81, 198);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 3;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(81, 236);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 4;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(81, 273);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 5;
            label6.Text = "Отчество";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(280, 330);
            button1.Name = "button1";
            button1.Size = new Size(178, 62);
            button1.TabIndex = 6;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(191, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(191, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(191, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(191, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 27);
            textBox4.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(562, 202);
            button2.Name = "button2";
            button2.Size = new Size(226, 80);
            button2.TabIndex = 11;
            button2.Text = "Список клиентов";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(634, 12);
            button3.Name = "button3";
            button3.Size = new Size(154, 57);
            button3.TabIndex = 12;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 55);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 13;
            label1.Text = "КЛИЕНТЫ";
            // 
            // Сustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Сustomers";
            Text = "Сustomers";
            WindowState = FormWindowState.Maximized;
            Load += Сustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}