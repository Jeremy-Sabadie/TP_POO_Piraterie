namespace TP_POO_Piraterie
{
    public class Navire
    {
        protected int x;
        protected int y;
        protected int flag;
        protected bool IsDestroy;

        public Navire(int x, int y, int flag, bool isDestroy)
        {
            Console.WriteLine("Abcisse x du navire?");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("ordonnée y du navire?");
            this.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Camp du navire?");
            this.flag = int.Parse(Console.ReadLine());
            IsDestroy = false;
        }
    }
}
