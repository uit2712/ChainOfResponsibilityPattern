namespace SimpleWhoIsBillionaire.Entities
{
    class Player
    {
        public string Name { get; set; }
        public long Money { get; set; }

        public Player(string name)
        {
            Name = name;
            Money = 0;
        }
    }
}
