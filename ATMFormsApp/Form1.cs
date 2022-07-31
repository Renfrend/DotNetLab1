using ATMClassLibrary;

namespace ATMFormsApp
{
    public partial class Form1 : Form
    {
        Atm atm = new Atm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Gobutton_Click(object sender, EventArgs e)
        {
            atm.AuthEvent += (obj, e) =>
            {

                MessageBox.Show("Аутентифіковано " + e.Result);
                if (e.Result == "Успішно")
                {
                    sumBox.PlaceholderText = "Сума";
                    sumBox.Text = "";
                    destBox.PlaceholderText = "Пункт призначення";
                    destBox.Text = "";
                    Gobutton.Visible = false;

                    AddButton.Visible = true;
                    WithdrawButton.Visible = true;
                    BalanceButton.Visible = true;
                    SendButton.Visible = true;
                    LogoutButton.Visible = true;
                }
            };
            Cards card = new Cards(int.Parse(sumBox.Text), int.Parse(destBox.Text));
            atm.Authenticate(card);
        }
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            atm.BalanceEvent += (obj, e) =>
            {
                MessageBox.Show("Ваш баланс: " + e.Balance);
            };
            atm.ShowBalance();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            atm.AddEvent += (obj, e) =>
            {
                MessageBox.Show("Транзакція успішна");
            };
            int n;
            if (int.TryParse(sumBox.Text, out n))
                atm.Add(n);
            else
            {
                MessageBox.Show("Введіть суму");
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            atm.WithdrawEvent += (obj, e) =>
            {
                if (e.Result)
                    MessageBox.Show(e.Sum + " списується з вашого балансу");
                else
                    MessageBox.Show("Недостатньо коштів на вашому балансі");
            };
            int n;
            if (int.TryParse(sumBox.Text, out n))
                atm.Withdraw(n);
            else
            {
                MessageBox.Show("Введіть суму");
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            atm.SendEvent += (obj, e) =>
            {
                if (e.Result)
                    MessageBox.Show("Транзакція успішна");
                else
                    MessageBox.Show("Сталася помилка. Транзакція не вдалася");
            };
            int a,b;
            if (int.TryParse(sumBox.Text, out a))
                if(int.TryParse(destBox.Text, out b))
                    atm.Send(a, b);
            else 
            {
                MessageBox.Show("Правильно введіть суму та призначення");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            atm.LogoutEvent += (obj, e) =>
            { 
                MessageBox.Show("Вихід..");
                MessageBox.Show("дані збережено");

                sumBox.PlaceholderText = "Номер картки";
                sumBox.Text = "";
                destBox.PlaceholderText = "PIN-код";
                destBox.Text = "";
                Gobutton.Visible = true;

                AddButton.Visible = false;
                WithdrawButton.Visible = false;
                BalanceButton.Visible = false;
                SendButton.Visible = false;
                LogoutButton.Visible = false;
            };
            atm.Logout();
        }
    }
}