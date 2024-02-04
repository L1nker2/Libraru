using Libraru.Models;
using System.Data;

namespace Libraru.Views
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
            LoadBooksUsers();
            LoadData();
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
        }
        void LoadBooksUsers()
        {
            using (DataBase db = new())
            {
                var users = db.Users.ToList();
                var books = db.Books.ToList();
                foreach (var user in users)
                {
                    comboBox2.Items.Add(user.FirstName + " " + user.LastName);
                }
                foreach (var book in books)
                {
                    comboBox1.Items.Add(book.Name);
                }
            }
        }
        void LoadData()
        {
            using (DataBase db = new())
            {
                var contracts = db.Contracts.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди", typeof(int));
                dt.Columns.Add("Книга", typeof(string));
                dt.Columns.Add("Получатель", typeof(string));
                dt.Columns.Add("Дата", typeof(string));
                dt.Columns.Add("Время", typeof(string));
                foreach (var contract in contracts)
                {
                    var user = db.Users.FirstOrDefault(el => el.Id == contract.UserId);
                    var book = db.Books.FirstOrDefault(el => el.Id == contract.BookId);
                    dt.Rows.Add(contract.Id, book.Name, user.FirstName + " " + user.LastName, contract.Date, contract.Time);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Size = new(1063, 253);
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
            DataBase.RemoveContract(id);
            MessageBox.Show("Запись удалена");
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            string bookName = comboBox1.SelectedItem.ToString();
            string[] userName = comboBox2.SelectedItem.ToString().Split(" ");
            string date = textBox3.Text;
            string time = textBox4.Text;
            using (DataBase dt = new())
            {
                var book = dt.Books.FirstOrDefault(el => el.Name == bookName);
                var user = dt.Users.FirstOrDefault(el => el.FirstName == userName[0] || el.LastName == userName[1]);
                DataBase.AddContract(book.Id, user.Id, date, time);
            }
            MessageBox.Show("Добавление успешно");
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.CloseForm(this);
        }
    }
}
