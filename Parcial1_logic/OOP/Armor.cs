namespace Parcial1_logic.OOP
{
    public class Armor:Gear
    {
        private double parametro_defense;
        private char type_def;

        // L = Light armor , H = Heavy Armor

        public Armor(): base()
        {
            Parametro_defense = 0;
            Type_def = ' ';
        }

        public double Parametro_defense { get => parametro_defense; set => parametro_defense = value; }
        public char Type_def { get => type_def; set => type_def = value; }

        public void parametro_defensa_tipo(double parametro_defense, char type_def)
        {
            if (type_def == 'H')
            {
                parametro_defense = 0.3;
            }
            if (type_def == 'L')
            {
                parametro_defense = 0.5;
            }
        }
    }
}