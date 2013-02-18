/*Inside the sea (a standard Cartesian /rectangular/ coordinate system) we are given a ship S
 (a rectangle whose sides are parallel to the coordinate axes), a horizontal line H (the horizon) and three catapults,
 given as coordinates C1, C2 and C3 that will be used to fire the ship. When the attack starts,
 each catapult shoots a projectile exactly into the positions that are symmetrical to C1, C2 and C3 
 with respect to the horizon H. When a projectile hits some of the corners of the ship,
 it causes a damage of 25%, when it hits some of the sides of the ship, the damage caused is 50% and when it hits the internal body of the ship, 
 the damage is 100%. When the projectile does not reach the ship, there is no damage. The total damage is a sum of the separate damages and can exceed 100%.*/

using System;

class ShipDamage
{
    static void Main()
    {
        string SX1str = Console.ReadLine();
        int SX1 = int.Parse(SX1str);
        string SY1str = Console.ReadLine();
        int SY1 = int.Parse(SY1str);
        string SX2str = Console.ReadLine();
        int SX2 = int.Parse(SX2str);
        string SY2str = Console.ReadLine();
        int SY2 = int.Parse(SY2str);
        string Hstr = Console.ReadLine();
        int H = int.Parse(Hstr);
        string CX1str = Console.ReadLine();
        int CX1 = int.Parse(CX1str);
        string CY1str = Console.ReadLine();
        int CY1 = int.Parse(CY1str);
        string CX2str = Console.ReadLine();
        int CX2 = int.Parse(CX2str);
        string CY2str = Console.ReadLine();
        int CY2 = int.Parse(CY2str);
        string CX3str = Console.ReadLine();
        int CX3 = int.Parse(CX3str);
        string CY3str = Console.ReadLine();
        int CY3 = int.Parse(CY3str);
        int Damage = 0;
        int CY1mirror = H + H - CY1;
        int CY2mirror = H + H - CY2;
        int CY3mirror = H + H - CY3;
        if ((CX1 > Math.Min(SX1, SX2) && CX1 < Math.Max(SX1, SX2)) && (CY1mirror > Math.Min(SY1, SY2) && (CY1mirror < Math.Max(SY1, SY2))))
            Damage = Damage + 100;
        if ((CX2 > Math.Min(SX1, SX2) && CX2 < Math.Max(SX1, SX2)) && (CY2mirror > Math.Min(SY1, SY2) && (CY2mirror < Math.Max(SY1, SY2))))
            Damage = Damage + 100;
        if ((CX3 > Math.Min(SX1, SX2) && CX3 < Math.Max(SX1, SX2)) && (CY3mirror > Math.Min(SY1, SY2) && (CY3mirror < Math.Max(SY1, SY2))))
            Damage = Damage + 100;
        if ((((CX1 == SX1 || CX1 == SX2))  && (CY1mirror > Math.Min(SY1, SY2) && (CY1mirror < Math.Max(SY1, SY2)))) || 
        ((CY1mirror == SY1 || CY1mirror == SY2) && (CX1 > Math.Min(SX1, SX2) && (CX1 < Math.Max(SX1, SX2)))))
            Damage = Damage + 50;
        if ((((CX2 == SX1 || CX2 == SX2)) && (CY2mirror > Math.Min(SY1, SY2) && (CY2mirror < Math.Max(SY1, SY2)))) ||
        ((CY2mirror == SY1 || CY2mirror == SY2) && (CX2 > Math.Min(SX1, SX2) && (CX2 < Math.Max(SX1, SX2)))))
            Damage = Damage + 50;
        if ((((CX3 == SX1 || CX3 == SX2)) && (CY3mirror > Math.Min(SY1, SY2) && (CY3mirror < Math.Max(SY1, SY2)))) ||
        ((CY3mirror == SY1 || CY3mirror == SY2) && (CX3 > Math.Min(SX1, SX2) && (CX3 < Math.Max(SX1, SX2)))))
            Damage = Damage + 50;
        if ((CX1 == SX1 || CX1 == SX2) && (CY1mirror == SY1 || CY1mirror == SY2))
            Damage = Damage + 25;
        if ((CX2 == SX1 || CX2 == SX2) && (CY2mirror == SY1 || CY2mirror == SY2))
            Damage = Damage + 25;
        if ((CX3 == SX1 || CX3 == SX2) && (CY3mirror == SY1 || CY3mirror == SY2))
            Damage = Damage + 25;
        Console.WriteLine(Damage + "%");
    }
}
