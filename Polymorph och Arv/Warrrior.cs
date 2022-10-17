using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_och_Arv
{
    public class Warrior : Class
    {
        public int numberOfSwords { get; set; }

        public override void WarCry()
        {
            Console.WriteLine("Warrior yells: CHARGE!");
        }

        public override void PrintInfo()
        {
        Console.WriteLine($"The {ClassName} has {Strength} in strenght and {Intelligence} in intelleigence.\n" +
                          $"The {ClassName} is wielding the legendary weapon {SpecialWeapon}, and his role in the raid is {RaidRole}.");
        }
    }
}
