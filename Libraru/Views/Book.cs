using Libraru.Models;
using System.Data;

namespace Libraru.Views
{
    public partial class Book : Form
    {
        void LoadData()
        {
            using (DataBase db = new())
            {
                var books = db.Books.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Айди", typeof(int));
                dataTable.Columns.Add("Название", typeof(string));
                dataTable.Columns.Add("Описание", typeof(string));
                dataTable.Columns.Add("Количество", typeof(int));
                foreach (var book in books)
                {
                    dataTable.Rows.Add(book.Id, book.Name, book.Description, book.Count);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public Book()
        {
            InitializeComponent();
            panel1.Visible = false;
            dataGridView1.Size = new Size(1063, 510);
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(1063, 175);
            panel1.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(dataGridView1.SelectedRows.Count > 0))
            {
                MessageBox.Show("Необходимо выбрать запись");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int.TryParse(row.Cells["Айди"].Value.ToString(), out int id);
            DataBase.RemoveBook(id);
            MessageBox.Show("Запись удалена");
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            string name = textBox1.Text;
            string description = textBox2.Text;
            int.TryParse(textBox3.Text, out int count);
            DataBase.AddBook(name, description, count);
            MessageBox.Show("Добавленно успешно");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 510);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.CloseForm(this);
        }
    }
}
