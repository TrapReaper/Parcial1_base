namespace Parcial1_logic.OOP
{
    public class Enemy:Actor, ICharacter
    {
        private char tipo_enemigo;
        private string arma_ene;
        private int daño_arm;
        private int armadura_ene;

        public char Tipo_enemigo { get => tipo_enemigo; set => tipo_enemigo = value; }
        public string Arma_ene { get => arma_ene; set => arma_ene = value; }
        public int Armadura_ene { get => armadura_ene; set => armadura_ene = value; }
        public int Daño_arm { get => daño_arm; set => daño_arm = value; }

        public Enemy()
        {
            tipo_enemigo = ' ';
            Health = 100;
            armadura_ene = 1;
            arma_ene = "";
            daño_arm = Base_atk + 2;
        }
    }
}