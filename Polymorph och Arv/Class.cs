using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_och_Arv
{
    public abstract class Class
    {
        public string ClassName { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public string SpecialWeapon { get; set; }

        public string RaidRole { get; set; }


        //public virtual void MountInfo() Om man vill använda sig av en metod som har en generell funktion, men går att ändra i subklasserna(barnklasser)
        //{
        //    Console.WriteLine("General class has 60% speed mount.");
        //}
    public abstract void PrintInfo();
    
    public abstract void WarCry();

    }

    

}
