using IterativeVsDeclarative;

List<Client> clients = new List<Client>()
{
    new Client(){ FullName = "Sergio", BalanceDebt = 1100, Status = ClientType.Defaulter },
    new Client(){ FullName = "Alejandro", BalanceDebt = 900, Status = ClientType.Defaulter },
    new Client(){ FullName = "Gabriel", BalanceDebt = 500, Status = ClientType.NotDefaulter }
};

//decimal totalDebt = 0;
//foreach (Client client in clients)
//{
//    if (client.Status == ClientType.Defaulter)
//    {
//        totalDebt += client.BalanceDebt;
//    }
//}

decimal totalDebt = (from client in clients
                     where client.Status == ClientType.Defaulter
                     select client.BalanceDebt).Sum();

Console.WriteLine(totalDebt);
Console.Read();