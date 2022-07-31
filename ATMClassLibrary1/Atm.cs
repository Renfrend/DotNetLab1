namespace ATMClassLibrary
{ 
    public class Atm
    {
        public bool Authentificated { get; private set; }
        public Cards Card { get; private set; }
        public int Balance { get; private set; }

        protected string startupPath;
        protected int[,] cards;
       
        public event EventHandler<AuthEventArgs> AuthEvent;
        public event EventHandler<BalanceEventArgs> BalanceEvent;
        public event EventHandler<WithdrawEventArgs> WithdrawEvent;
        public event EventHandler<SendEventArgs> SendEvent;
        public event EventHandler<EventArgs> LogoutEvent;
        public event EventHandler<EventArgs> AddEvent;

        public Atm ()
        {
            Authentificated = false;
            startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "cards.txt");
            cards = ReadArray(startupPath);
        }
        public void showcards()
        {
            for (int i = 0; i < cards.GetLength(0); i += 1)
            {
                for (int j = 0; j < cards.GetLength(1); j += 1)
                {
                    Console.Write(cards[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
     
        protected int[,] ReadArray(string path)
        {
            int[,] arr;
            using (StreamReader sr = new StreamReader(path))
            {
                int n = int.Parse(sr.ReadLine()); 
                int m = int.Parse(sr.ReadLine()); 
                arr = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    string temp = sr.ReadLine();
                    string[] line = temp.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = int.Parse(line[j]);
                    }
                }
            }
            return arr;
        }
        protected void WriteArray(string path, int[,] array)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(array.GetLength(0));
                sw.WriteLine(array.GetLength(1));
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    string[] line = new string[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {                      
                        line[j] = array[i, j].ToString();
                    }
                    sw.WriteLine(String.Join(" ", line));
                }
            }
        }  
        public void Logout()
        {
            if (Authentificated)
            {
                Authentificated = false;
                for (int i = 0; i < cards.GetLength(0); i += 1)
                {
                    if (cards[i, 0] == Card.Number)
                    {
                        cards[i, 2] = Balance;
                        break;
                    }
                }
                WriteArray(startupPath, cards);
                if (LogoutEvent != null)
                    LogoutEvent(this, new EventArgs());
            }
        }
        public bool Send(int sum, int Number)  
        {
            if (Authentificated)
            {
                bool result;
                if (Balance - sum < 0)
                    result = false;

                bool found = false;
                for (int i = 0; i < cards.GetLength(0); i += 1)
                {
                    if (cards[i, 0] == Number)
                    {
                        found = true;
                        cards[i, 2] += sum;
                        break;
                    }
                }

                if (found)
                {
                    Balance -= sum;
                    result = true;
                }
                else result = false;

                if (SendEvent != null)
                    SendEvent(this, new SendEventArgs(result));
                return result;
            }
            return false;
        }
        public bool Withdraw(int sum) 
        {
            if (Authentificated)
            {
                bool result;
                if (Balance - sum < 0)
                    result = false;
                else
                {
                    Balance -= sum;
                    result = true;
                }
                if (WithdrawEvent != null)
                    WithdrawEvent(this, new WithdrawEventArgs(result, sum));
                return result;
            }
            return false;
        }
        public int Add(int sum) 
        {
            int result = 0;
            if (Authentificated)
            {
                Balance += sum;
                result = ShowBalance();
            }
            
            if (AddEvent != null)
                AddEvent(this, new EventArgs());
            return result;
        }
        public int ShowBalance() 
        {
            if (Authentificated)
            {
                OnShowBalanceEvent(Balance);
                return Balance;
            }
            return 0;
        }
        public string Authenticate(Cards card)
        {

            string result = "Помилка";
            
            for (int i = 0; i < cards.GetLength(0); i+=1)
            {
                if (cards[i,0] == card.Number)
                {
                    
                    if (cards[i, 1] == card.Pincode)
                    {
                        Authentificated = true;
                        Card = card;
                        Balance = cards[i, 2];
                        result = "Успішно";
                        break;
                    }
                    else
                    {
                        result = "Помилка.Пінкод не вірний";
                        break;
                    }
                    
                }
            }
            if (result == "Помилка")
            {
                
                result = "Номер карти не вірний";
            }
            

  
            if (AuthEvent != null)
                AuthEvent(this, new AuthEventArgs(result));

            return result;
        }
        protected void OnShowBalanceEvent(int balance)
        {
            if (BalanceEvent != null)
                BalanceEvent(this, new BalanceEventArgs(balance));
        }
    }
}