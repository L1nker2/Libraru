namespace Libraru.Views
{
    partial class Book
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1063, 175);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 533);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 533);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(452, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 392);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(5, 345);
            button4.Name = "button4";
            button4.Size = new Size(193, 41);
            button4.TabIndex = 6;
            button4.Text = "Подтвердить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(90, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 273);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Количество";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(5, 99);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 166);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Описание";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // button3
            // 
            button3.Location = new Point(963, 537);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 14;
            button3.Text = "Закрыть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Book
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
            Name = "Book";
            Text = "Book";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Button button3;
    }
}