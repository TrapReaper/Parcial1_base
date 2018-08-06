namespace Parcial1_logic.OOP
{
    public class NPC: Actor , ICharacter
    {
        private int type;
        private int stockA;
        private int stockB;
        private int stockC;
        private int stockD;

        public int StockA { get => stockA; set => stockA = value; }
        public int StockB { get => stockB; set => stockB = value; }
        public int StockC { get => stockC; set => stockC = value; }
        public int StockD { get => stockD; set => stockD = value; }

        public NPC():base()
        {
            type = 1;
            Currency = 10000;
            Base_atk = 0;
            Base_def = 0;
            StockA = 50;
            stockB = 100;
            stockC = 12;
            stockD = 5;
        }
    }
}