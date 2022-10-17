using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_och_Arv
{
    public class Priest : Class
    {
        public int numberOfStaves { get; set; }
        public override void WarCry()
        {
            Console.WriteLine("Priests yells: By the Elune!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"The {ClassName}  has {Strength} in strenght and {Intelligence} in intelleigence.\n" +
                              $"{SpecialWeapon} is hers special weapon, and his role in the raid is {RaidRole}.");
        }
    }
}
