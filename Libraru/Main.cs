using Libraru.Views;

namespace Libraru
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            openChildForm(new Welcome());
        }
        private static Form activeForm = null;
        private static void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            viewPanel.Controls.Add(childForm);
            viewPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public static void CloseForm(Form activeForm)
        {
            activeForm.Close();
            openChildForm(new Welcome());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Book());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new User());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Contract());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Return());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал студент группы 404-ИС Попова Анастасия Дмитриевна");
        }
    }
}
