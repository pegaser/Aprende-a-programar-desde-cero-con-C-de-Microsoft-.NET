namespace IterativeVsDeclarative
{
    internal class Client
    {
        public string FullName { get; set; }
        public ClientType Status { get; set; }
        public decimal BalanceDebt { get; set; }

        public Client()
        {
            FullName = "Default FullName";
        }
    }

    enum ClientType
    {
        Defaulter, NotDefaulter
    }
}
