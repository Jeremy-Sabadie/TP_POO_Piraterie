namespace TP_POO_Piraterie
{
    public class Navire
    {
        protected int x { get; set; }
        protected int y { get; set; }
        protected int flag;
        protected bool IsDestroy;

        public Navire(int x, int y, int flag)
        {
            //Console.WriteLine("Abcisse x du navire?");
            //this.x = int.Parse(Console.ReadLine());
            //Console.WriteLine("ordonnée y du navire?");
            //this.y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Camp du navire?");
            //this.flag = int.Parse(Console.ReadLine());
            IsDestroy = false;
        }
        public double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public void Sink()
        {
            if (IsDestroy == true)
            {
                Console.WriteLine("Coulé");
            }
            else { Console.WriteLine("Non coulé."); }
        }
        public void Advance(int MooveX, int mooveY)
        {
            x = x + MooveX;
            y = y + mooveY;

        }
        public void Print()
        {
            Console.WriteLine($" Abcisse x= {x}.");
            Console.WriteLine($" Ordonnee y= {y}.");
        }
    }
}
