using Libraru.Models;
using System.Data;

namespace Libraru.Views
{
    public partial class User : Form
    {
        void LoadData()
        {
            using (DataBase db = new())
            {
                var users = db.Users.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди", typeof(int));
                dt.Columns.Add("Имя", typeof(string));
                dt.Columns.Add("Фамилия", typeof(string));
                dt.Columns.Add("Возраст", typeof(string));
                dt.Columns.Add("email", typeof(string));
                foreach (var user in users)
                {
                    dt.Rows.Add(user.Id, user.FirstName, user.LastName, user.Year, user.Email);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public User()
        {
            InitializeComponent();
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
            LoadData();
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
            DataBase.RemoveUser(id);
            MessageBox.Show("Запись удалена");
            LoadData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string year = textBox3.Text;
            string email = textBox4.Text;
            DataBase.AddUser(fname, lname, year, email);
            MessageBox.Show("Добавление успешно");
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.CloseForm(this);
        }
    }
}
