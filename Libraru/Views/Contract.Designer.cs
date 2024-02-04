namespace Libraru.Views
{
    partial class Contract
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
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(300, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 308);
            panel1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(5, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 28);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(5, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 197);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Время";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(5, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(5, 258);
            button4.Name = "button4";
            button4.Size = new Size(193, 41);
            button4.TabIndex = 6;
            button4.Text = "Подтвердить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 135);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 73);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Получатель";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Книга";
            // 
            // button2
            // 
            button2.Location = new Point(152, 537);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 11;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 537);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1063, 253);
            dataGridView1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(963, 537);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 13;
            button3.Text = "Закрыть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Contract
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 584);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contract";
            Text = "Contract";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}