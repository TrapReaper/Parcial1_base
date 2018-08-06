 namespace Parcial1_logic.OOP
{
    public class Hero : Actor, ICharacter
    {
        private int current_attack;
        private int current_defense;
        private bool weapon;
        private bool armor;
        private int base_a;
        private int base_d;

        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }
        public int Current_attack { get => current_attack; set => current_attack = value; }
        public int Current_defense { get => current_defense; set => current_defense = value; }
        public bool Armor { get => armor; set => armor = value; }
        public int Base_a { get => base_a; set => base_a = value; }
        public int Base_d { get => base_d; set => base_d = value; }

        public Hero(Weapon arma, Armor armadura):base()
        {
            Name = "";
            Health = 100;
            Currency = 0;
            current_attack = 0;
            current_defense = 0;
            weapon = false;
            armor = false;
            Base_a = Base_atk;
            Base_d = Base_def;
        }

        public void Actual_atact(int base_atk, int current_attack, double x, Weapon arma)
        {

            if (weapon == true)
            {
                current_attack = base_atk + (base_atk / 100 * Base_a);
            }
            else
            {
                current_attack = base_atk;
            }
        }

        public void Actual_defense(int base_defense, int current_defense, Armor armadura)
        {
            if (armor == true)
            {
                current_defense = base_defense + (base_defense / 100 * base_d);
            }
        }


        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }
    }
}