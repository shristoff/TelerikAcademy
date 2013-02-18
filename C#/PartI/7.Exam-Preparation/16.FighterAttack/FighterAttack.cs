/* A rectangular plant P located in east-west direction is under attack by a fighter aircraft flying over it on the west. 
When the fighter launches a missile we have its coordinates F. It is assumed that the missile's direction is always straight on
the west and the missile always hits the target after a fixed distance D in front of the fighter.
To simplify our model we assume the land is built of square cells of size 1 x 1 located in east-west direction and each cell has integer 
Cartesian coordinates {x, y}. In this model the plant can be represented by a rectangular area of cell and the missile always hits some 
of the square cells (inside or outside of the plant). When the missile hits a certain cell, the damage over it is 100%, on the cells 
staying on the left and on the right of it the damage is 50% and in front of it the damage is 75%. The total damage is sum of the 
separate damages and can exceed 100%.You are given the location of the plant P, the location of the fighter F and the distance D. 
Write a program that calculates the damage over the plant after the attack. Note that the missile could hits the plant partially of 
fully or can hit some area outside of the plant and cause no damage. */

using System;

class FighterAttack
{
    static void Main()
    {
        string PX1str = Console.ReadLine();
        int PX1 = int.Parse(PX1str);
        string PY1str = Console.ReadLine();
        int PY1 = int.Parse(PY1str);
        string PX2str = Console.ReadLine();
        int PX2 = int.Parse(PX2str);
        string PY2str = Console.ReadLine();
        int PY2 = int.Parse(PY2str);
        string FXstr = Console.ReadLine();
        int FX = int.Parse(FXstr);
        string FYstr = Console.ReadLine();
        int FY = int.Parse(FYstr);
        string Dstr = Console.ReadLine();
        int D = int.Parse(Dstr);
        int Damage = 0, temp;
        if (PX1 >= PX2)
        {
            temp = PX1;
            PX1 = PX2;
            PX2 = temp;
        }
        if (PY1 >= PY2)
        {
            temp = PY1;
            PY1 = PY2;
            PY2 = temp;
        }
        if (FX + D >= PX1 && FX + D + 1 <= PX2 && FY - 1 >= PY1 && FY + 1 <= PY2)  // All in
            Damage = 275;
        if (FX + D >= PX1 && FY == PY2 && FX + D + 1 <= PX2 && FY - 1 >= PY1)  // only upper 50 out
            Damage = 225;
        if (FX + D >= PX1 && FY == PY1 && FX + D + 1 <= PX2 && FY + 1 <= PY2)  // only down 50 out
            Damage = 225;
        if (FX + D >= PX1 && FY == PY1 && FY == PY2 && FX + D + 1 <= PX2)  // only 100 & 75 in
            Damage = 175;
        if (FY == PY1 && FX + D + 1 == PX1) // only 75 in
            Damage = 75;
        if (FX + D == PX2 && FY == PY2)  // 100 & down 50 in
            Damage = 150;
        if (FX + D == PX2 && FY == PY1)  // 100 & upper 50 in
            Damage = 150;
        if (FX + D >= PX1 && FX + D <= PX2 && FY + 1 == PY1)  // only upper 50 in
            Damage = 50;
        if (FX + D >= PX1 && FX + D <= PX2 && FY - 1 == PY2)   // only down 50 in
            Damage = 50;
        if (FX + D == PX2 && FY == PY1 && FY == PY2) //only 100 in
            Damage = 100;
        Console.WriteLine(Damage + "%");
    }
}