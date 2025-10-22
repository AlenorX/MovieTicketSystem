using System.Text.Json;
using System.Transactions;
using System.Web;

namespace ProgramOrder
{
    public partial class Form1 : Form
    {
        protected class User()
        {
            public string login { get; set; }
            public int money { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        public string[] nameFilms = ["Человек паук", "Веном", "Ужасающий", "Твоё имя", "Клинок Рассекающий Демонов: Бесконечный замок 1"];
        DataTransfer dataTransfer = new DataTransfer();
        User user = new User();
        public string nicknameData;
        public string passwordData;


        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            dateNow.Text = $"Сегодня {dateTime.Day}.{dateTime.Month}.{dateTime.Year}";
            Random random = new Random();
            CinemaName.Text = $"В кино идёт фильм: {nameFilms[random.Next(0, nameFilms.Length)]}";
        }

        private void SignIn_Click(object sender, EventArgs e)
        {

            nicknameData = NickNameBox.Text;
            passwordData = PasswordBox.Text;
            string response = dataTransfer.SignIn(nicknameData, passwordData);
            user = JsonSerializer.Deserialize<User>(response);
            NickName.Text = user.login;
            Balance.Text = Convert.ToString(user.money);
            NickNameBox.Enabled = false;
            PasswordBox.Enabled = false;
            SignIn.Enabled = false;
            Registration.Enabled = false;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            nicknameData = NickNameBox.Text;
            passwordData = PasswordBox.Text;
            string response = dataTransfer.Registration(nicknameData, passwordData);
            user = JsonSerializer.Deserialize<User>(response);
            NickName.Text = user.login;
            Balance.Text = Convert.ToString(user.money);
            NickNameBox.Enabled = false;
            PasswordBox.Enabled = false;
            SignIn.Enabled = false;
            Registration.Enabled = false;
        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            int monetaryTransaction = 100 * trackBar.Value;
            int money = Convert.ToInt32(Balance.Text) - monetaryTransaction;
            string result = dataTransfer.BuyTicket(NickName.Text, money);
            StatusPurchased.Text = result;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            PriceTicket.Text = $"Итоговая стоимость: {100 * trackBar.Value}";
        }
    }
}
