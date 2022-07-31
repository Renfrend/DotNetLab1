using ATMClassLibrary;

Console.OutputEncoding = System.Text.Encoding.Default;

void AuthHandler(object sender, AuthEventArgs e)
{
    Console.WriteLine("Авторизація " + e.Result) ;
}
void BalanceHandler(object sender, BalanceEventArgs e)
{
    Console.WriteLine("Ваш баланс: " + e.Balance);
}
void WithdrawHandler(object sender, WithdrawEventArgs e)
{
    if (e.Result)
        Console.WriteLine(e.Sum + " знято з вашої картки");
    else
        Console.WriteLine("Недостатньо коштів на балансі");
}
void SendHandler(object sender, SendEventArgs e)
{
    if(e.Result)
    Console.WriteLine("Транзакція успішна");
    else
        Console.WriteLine("Виникла помилка");
}
void LogoutHandler(object sender, EventArgs e)
{
    Console.WriteLine("Вихід..");
    Console.WriteLine("Дані збережені");
}

Atm atm = new Atm();
atm.AuthEvent += AuthHandler;
atm.BalanceEvent += BalanceHandler;
atm.WithdrawEvent += WithdrawHandler;
atm.SendEvent += SendHandler;
atm.LogoutEvent += LogoutHandler;

bool auted = true;
while (auted)
{
    Console.WriteLine("Введіть номер картки");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть пінкод");
    int pincode = int.Parse(Console.ReadLine());
    Cards card1 = new Cards(number, pincode);
    if (atm.Authenticate(card1) == "Успішно")
        auted = false;
    
}

bool cikl = true;
while (cikl)
{
    Console.WriteLine("Виберіть дію");
    Console.WriteLine("1 - Баланс, 2 - Нарахувати кошти, 3 - Зняти кошти, 4 - Надіслати кошти, інше - Вийти");
    int choose = int.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            atm.ShowBalance();
            break;
        case 2:
            Console.WriteLine("Введіть суму грошей, яку хочете нарахувати");
            int sum = int.Parse(Console.ReadLine());
            if(sum<=0)
                Console.WriteLine("Сума не може бути 0 або менше");
            else
            atm.Add(sum);
            break;
        case 3:
            Console.WriteLine("Введіть суму грошей, яку хочете зняти");
            int wr = int.Parse(Console.ReadLine());
            if (wr <= 0)
                Console.WriteLine("Сума не може бути 0 або менше");
            else
                atm.Withdraw(wr);
            break;
        case 4:
            Console.WriteLine("Введіть номер картки");
            int dest = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть суму грошей, яку хочете надіслати");
            int pr = int.Parse(Console.ReadLine());
            if (pr <= 0)
                Console.WriteLine("Сума не може бути 0 або менше");
            else
                atm.Send(pr, dest);
            break;
        default:
            atm.Logout();
            cikl = false;
            break;
    }
}