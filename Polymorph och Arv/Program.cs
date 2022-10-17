using System.ComponentModel;
using Polymorph_och_Arv;

var paladin = new Paladin();
var priest = new Priest();
var warrior = new Warrior();

var classes = new List<Class>();

classes.Add(paladin);
classes.Add(priest);
classes.Add(warrior);

paladin.ClassName = "Paladin";
paladin.Strength = 6;
paladin.Intelligence = 4;
paladin.SpecialWeapon = "Ashbringer";
paladin.RaidRole = "damage dealer";
paladin.numberOfHammers = 3;

priest.ClassName = "Priest";
priest.Strength = 1;
priest.Intelligence = 9;
priest.SpecialWeapon = "Benediction";
priest.RaidRole = "healer";
priest.numberOfStaves = 2;

warrior.ClassName = "Warrior";
warrior.Strength = 9;
warrior.Intelligence = 1;
warrior.SpecialWeapon = "Thunderfury, blessed blade of the windseeker";
warrior.RaidRole = "tank";
warrior.numberOfSwords = 99;

foreach (var a in classes)
{
    a.PrintInfo();
    a.WarCry();
    Console.WriteLine();
}

