using Libraru.Models;
using System.Data;

namespace Libraru.Views
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            LoadData();
            LoadContracts();
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
        }
        void LoadContracts()
        {
            using (DataBase db = new())
            {
                var contracts = db.Contracts.ToList();
                foreach (var contract in contracts)
                {
                    comboBox1.Items.Add(contract.Id);
                }
            }
        }
        void LoadData()
        {
            using (DataBase db = new())
            {
                var returns = db.Returns.ToList();
                DataTable dt = new();
                dt.Columns.Add("Айди", typeof(int));
                dt.Columns.Add("Айди выписки", typeof(int));
                dt.Columns.Add("Задержка", typeof(bool));
                foreach (var return_ in returns)
                {
                    dt.Rows.Add(return_.Id, return_.ContractId, return_.Delay);
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
            panel1.Visible = true;
            dataGridView1.Size = new(1063, 362);
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
            DataBase.RemoveReturn(id);
            MessageBox.Show("Запись удалена");
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(comboBox1.SelectedItem.ToString(), out int id);
            bool delay = checkBox1.Checked;
            DataBase.AddReturn(id, delay);
            MessageBox.Show("Добавление успешно");
            LoadData();
            panel1.Visible = false;
            dataGridView1.Size = new(1063, 511);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.CloseForm(this);
        }
    }
}
