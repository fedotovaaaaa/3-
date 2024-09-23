using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApp1.UsersClasses;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "paokin@bk.ru";
            textBoxName.Text = "Антон Игоревич";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
            string.IsNullOrWhiteSpace(textBoxName.Text) ||
             string.IsNullOrWhiteSpace(textBoxSubject.Text) ||
              string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля!!!!!");
                return;
            }

            string smtp = "smtp.mail.ru";

            StringPair fromInfo = new StringPair("nastya.12v@mail.ru", "Власова А.С. и Парфенова А.С.");

            string password = "5q8F0u0rtQGPiAU0wWZU";

            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);
            string subject = textBoxSubject.Text;
            string body = $"{DateTime.Now}\n" +
            $"{Dns.GetHostName()}\n" +
            $"{Dns.GetHostAddresses(Dns.GetHostName()).First()}\n" +
            $"{textBoxBody.Text}";

            InfoEmailSending info =
            new InfoEmailSending(smtp, fromInfo, password, toInfo, subject, body);
            SendingEmail sendingEmail = new SendingEmail(info);
            sendingEmail.Send();

            MessageBox.Show("Письмо отправлено!УРАААААААА!!!!!");
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
