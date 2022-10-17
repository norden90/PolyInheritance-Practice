using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_och_Arv
{
    public class Paladin : Class
    {
        public int numberOfHammers { get; set; }
        public override void WarCry()
        {
            Console.WriteLine("The paladin yells: FOR THE SILVERHAND!");
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"The {ClassName} has {Strength} in strenght and {Intelligence} in intelleigence.\n" +
                              $"{SpecialWeapon} is his special weapon, and his role in the raid is {RaidRole}.");
        }
    }
}
