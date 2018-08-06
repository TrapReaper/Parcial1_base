namespace Parcial1_logic.OOP
{
    public class Weapon:Gear
    {
        private double paramatk;
        private char type;

        // Types son L(Lanza), S(espada)

        public double Paramatk { get => paramatk; set => paramatk = value; }
        public char Type { get => type; set => type = value; }

        public Weapon():base()
        {
            paramatk = 0;
            type = ' ';
        }

        public void parametro_ataque(double paramatk, char type)
        {
            if(type == 'L')
            {
                paramatk = 0.3;
            }
            if (type == 'S')
            {
                paramatk = 0.5;
            }
        }

    }
}