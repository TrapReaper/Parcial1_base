namespace Parcial1_logic.OOP
{
    public class Gear
    {
        private int durabilidad;
        private int categoria;

        // 1 =  Normal , 2 = Raro, 3 = Legendario

        public int Durabilidad { get => durabilidad; set => durabilidad = value; }
        public int Categoria { get => categoria; set => categoria = value; }

        
        public Gear()
        {
            durabilidad = 0;
            categoria = 1;
        }
    }
}