namespace TP_POO_Piraterie;

public class MerchantShip : Navire
{
    public MerchantShip(int x, int y, int flag) : base(x, y, flag)
    {

        //Console.WriteLine("Abcisse x du navire?");
        //this.x = int.Parse(Console.ReadLine());
        //Console.WriteLine("ordonnée y du navire?");
        //this.y = int.Parse(Console.ReadLine());
        //Console.WriteLine("Camp du navire?");
        //this.flag = int.Parse(Console.ReadLine());
        IsDestroy = false;
    }

}
