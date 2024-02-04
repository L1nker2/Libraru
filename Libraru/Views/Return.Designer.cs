namespace Libraru.Views
{
    partial class Return
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
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(288, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 195);
            panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 106);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(5, 141);
            button4.Name = "button4";
            button4.Size = new Size(193, 41);
            button4.TabIndex = 6;
            button4.Text = "Подтвердить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 74);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 2;
            label2.Text = "Возврат с задержкой";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 7);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Сделка";
            // 
            // button3
            // 
            button3.Location = new Point(963, 537);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 19;
            button3.Text = "Закрыть";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 537);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 17;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 537);
            button1.Name = "button1";
            button1.Size = new Size(130, 39);
            button1.TabIndex = 16;
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
            dataGridView1.Size = new Size(1063, 362);
            dataGridView1.TabIndex = 15;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 584);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Return";
            Text = "Return";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
    }
}