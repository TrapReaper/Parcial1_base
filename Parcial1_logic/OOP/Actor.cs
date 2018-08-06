namespace Parcial1_logic.OOP
{
    public abstract class Actor
    {
        private string name;
        private int health;
        private int currency;
        private int base_atk;
        private int base_def;
        private int vel;

        public string Name { get => name; set => name = value; }
        public int Currency { get => currency; set => currency = value; }
        public int Base_atk { get => base_atk; set => base_atk = value; }
        public int Base_def { get => base_def; set => base_def = value; }
        public int Vel { get => vel; set => vel = value; }
        public int Health { get => health; set => health = value; }

        public Actor()
        {
            name = "";
            health = 100;
            currency = 0;
            base_atk = 1;
            base_def = 1;
            vel = 3;
        }
    }
}