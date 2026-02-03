using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using game.Items;
using game.Mechanics;

namespace game.Characters
{
    enum DemonType
    {
        Damned,
        Soldier,
        Dealer,
        Royal,
        Lord
    }
    internal class Demon : Enemy
    {
        internal DemonType Type;

        internal Demon GenerateDemon(string type, string name)
        {
            switch (type)
            {
                case "Damned":
                    return CreateNewDamned(name);
                case "Soldier":
                    return CreateNewSoldier(name);
                case "Dealer":
                    return CreateNewDealer(name);
                case "Royal":
                    return CreateNewRoyal(name);
                case "Lord":
                    return CreateNewLord(name);
                default:
                    return CreateNewDamned(name);
            }
        }

        readonly Weapon _weaponLoadout;
        readonly Armor _armorLoadout;

        private Demon CreateNewDamned(string name)
        {
            var damned = new Demon();
            
            damned.Type = DemonType.Damned;
            damned.IsBoss = false;

            damned.Name = name;
            damned.Description = "A hellbound mortal soul dripping with pure evil.";
            damned.Race = Race.Demon;
            damned.IsLiving = false;
            damned.Class = CharacterClass.Fighter;
            damned.Height = new Random().Next(30, 91);
            damned.Weight = new Random().Next(50, 301);
            damned.Age = new Random().Next(1, 15001);
            damned.Ethics = Ethics.Chicanery;
            damned.Morals = Morals.Treachery;

            damned.Vision = new Random().Next(40, 81);
            damned.Agility = new Random().Next(40, 81);
            damned.Luck = new Random().Next(40, 81);
            damned.Understanding = new Random().Next(40, 81);
            damned.Empathy = new Random().Next(10, 51);
            damned.Salubrity = new Random().Next(50, 91);

            damned.Weapons.Add(_weaponLoadout.InfernumDagger());
            damned.Weapons.Add(_weaponLoadout.Fists());
            damned.CurrentWeapon = damned.Weapons.ElementAt(0);
            damned.Armor.Add(_armorLoadout.UnholyRobes());
            damned.Range = 10;
            damned.Proficiency = Proficiency.Melee;
            damned.Attack = new Random().Next(50, 81) + damned.CurrentWeapon.Damage;
            damned.Defense = 75 + damned.Armor.ElementAt(0).Defense + damned.Salubrity;
            damned.Tactics = Tactics.Aggressive;
            damned.Health = 666;

            damned.CriticalHitRate = CalculateCritRate(damned.Vision, damned.Agility, damned.Luck, damned.Attack, damned.Type);
            damned.Items = new List<Item>();
            damned.Abilities = new List<Ability>();

            return damned;
        }

        private Demon CreateNewSoldier(string name)
        {
            var soldier = new Demon();

            soldier.Type = DemonType.Soldier;
            soldier.IsBoss = false;

            soldier.Name = name;
            soldier.Description = "A fiercely obedient knight in Rhazhaq's army.";
            soldier.Race = Race.Demon;
            soldier.IsLiving = false;
            soldier.Class = CharacterClass.Knight;
            soldier.Height = new Random().Next(60, 91);
            soldier.Weight = new Random().Next(120, 351);
            soldier.Age = new Random().Next(20, 15001);
            soldier.Ethics = Ethics.Rigidity;
            soldier.Morals = Morals.Treachery;

            soldier.Vision = new Random().Next(60, 91);
            soldier.Agility = new Random().Next(60, 91);
            soldier.Luck = new Random().Next(40, 81);
            soldier.Understanding = new Random().Next(50, 81);
            soldier.Empathy = new Random().Next(10, 51);
            soldier.Salubrity = new Random().Next(60, 91);

            soldier.Weapons.Add(_weaponLoadout.InfernumLance());
            soldier.Weapons.Add(_weaponLoadout.Fists());
            soldier.CurrentWeapon = soldier.Weapons.ElementAt(0);
            soldier.Armor.Add(_armorLoadout.InfernumChainMail());
            soldier.Range = 20;
            soldier.Proficiency = Proficiency.Two_Handed;
            soldier.Attack = new Random().Next(130, 161) + soldier.CurrentWeapon.Damage;
            soldier.Defense = 150 + soldier.Armor.ElementAt(0).Defense + soldier.Salubrity;
            soldier.Tactics = Tactics.Aggressive;
            soldier.Health = 3333;

            soldier.CriticalHitRate = CalculateCritRate(soldier.Vision, soldier.Agility, soldier.Luck, soldier.Attack, soldier.Type);
            soldier.Items = new List<Item>();
            soldier.Abilities = new List<Ability>();

            return soldier;
        }

        private Demon CreateNewDealer(string name)
        {
            var dealer = new Demon();

            dealer.Type = DemonType.Dealer;
            dealer.IsBoss = false;

            dealer.Name = name;
            dealer.Description = "A demon with the power to grant wishes - at a terrible cost.";
            dealer.Race = Race.Demon;
            dealer.IsLiving = false;
            dealer.Class = CharacterClass.Rogue;
            dealer.Height = new Random().Next(60, 91);
            dealer.Weight = new Random().Next(120, 301);
            dealer.Age = new Random().Next(20, 15001);
            dealer.Ethics = Ethics.Chicanery;
            dealer.Morals = Morals.Treachery;

            dealer.Vision = new Random().Next(40, 91);
            dealer.Agility = new Random().Next(40, 91);
            dealer.Luck = new Random().Next(75, 101);
            dealer.Understanding = new Random().Next(60, 91);
            dealer.Empathy = new Random().Next(70, 101);
            dealer.Salubrity = new Random().Next(40, 91);

            dealer.Weapons.Add(_weaponLoadout.InfernumSword());
            dealer.Weapons.Add(_weaponLoadout.Fists());
            dealer.CurrentWeapon = dealer.Weapons.ElementAt(0);
            dealer.Armor.Add(_armorLoadout.InfernumShield());
            dealer.Armor.Add(_armorLoadout.InfernumPlateMail());
            dealer.Range = 15;
            dealer.Proficiency = Proficiency.One_Handed;
            dealer.Attack = new Random().Next(250, 301) + dealer.CurrentWeapon.Damage;
            dealer.Defense = 300 + dealer.Armor.ElementAt(0).Defense + dealer.Armor.ElementAt(1).Defense + dealer.Salubrity;
            dealer.Tactics = Tactics.Aggressive;
            dealer.Health = 6666;

            dealer.CriticalHitRate = CalculateCritRate(dealer.Vision, dealer.Agility, dealer.Luck, dealer.Attack, dealer.Type);
            dealer.Items = new List<Item>();
            dealer.Abilities = new List<Ability>();

            return dealer;
        }

        private Demon CreateNewRoyal(string name)
        {
            var royal = new Demon();

            royal.Type = DemonType.Royal;
            royal.IsBoss = true;

            royal.Name = name;
            royal.Description = "One of Rhazhaq's most trusted subordinates; truly a force to be reckoned with.";
            royal.Race = Race.Demon;
            royal.IsLiving = false;
            royal.Class = CharacterClass.Noble;
            royal.Height = new Random().Next(120, 181);
            royal.Weight = new Random().Next(300, 601);
            royal.Age = new Random().Next(500, 15001);
            royal.Ethics = Ethics.Rigidity;
            royal.Morals = Morals.Treachery;

            royal.Vision = new Random().Next(75, 101);
            royal.Agility = new Random().Next(75, 101);
            royal.Luck = new Random().Next(50, 101);
            royal.Understanding = new Random().Next(60, 101);
            royal.Empathy = new Random().Next(50, 91);
            royal.Salubrity = new Random().Next(75, 101);

            royal.Weapons.Add(_weaponLoadout.InfernumPitchfork());
            royal.Weapons.Add(_weaponLoadout.Fists());
            royal.CurrentWeapon = royal.Weapons.ElementAt(0);
            royal.Armor.Add(_armorLoadout.InfernumPlateMail());
            royal.Range = 20;
            royal.Proficiency = Proficiency.Two_Handed;
            royal.Attack = new Random().Next(500, 601) + royal.CurrentWeapon.Damage;
            royal.Defense = 600 + royal.Armor.ElementAt(0).Defense + royal.Salubrity;
            royal.Tactics = Tactics.Aggressive;
            royal.Health = 16666;

            royal.CriticalHitRate = CalculateCritRate(royal.Vision, royal.Agility, royal.Luck, royal.Attack, royal.Type);
            royal.Items = new List<Item>();
            royal.Abilities = new List<Ability>();

            return royal;
        }

        private Demon CreateNewLord(string name)
        {
            var lord = new Demon();

            lord.Type = DemonType.Lord;
            lord.IsBoss = true;
            lord.Name = name;
            lord.Description = "An elite demon who works directly with Rhazhaq himself and has a reputation for being particularly vile.";
            lord.Race = Race.Demon;
            lord.IsLiving = false;
            lord.Class = CharacterClass.Noble;
            lord.Height = new Random().Next(150, 241);
            lord.Weight = new Random().Next(600, 1201);
            lord.Age = new Random().Next(1000, 15001);
            lord.Ethics = Ethics.Rigidity;
            lord.Morals = Morals.Treachery;

            lord.Vision = new Random().Next(80, 101);
            lord.Agility = new Random().Next(80, 101);
            lord.Luck = new Random().Next(80, 101);
            lord.Understanding = new Random().Next(80, 101);
            lord.Empathy = new Random().Next(80, 101);
            lord.Salubrity = new Random().Next(80, 101);

            lord.Weapons.Add(_weaponLoadout.InfernumWhip());
            lord.Weapons.Add(_weaponLoadout.InfernumFlail());
            lord.Weapons.Add(_weaponLoadout.Fists());
            lord.CurrentWeapon = lord.Weapons.ElementAt(0);
            lord.Armor.Add(_armorLoadout.DarkMagickInfernumPlateMail());
            lord.Range = 50;
            lord.Proficiency = Proficiency.One_Handed;
            lord.Attack = new Random().Next(1500, 1601) + lord.CurrentWeapon.Damage;
            lord.Defense = 2000 + lord.Armor.ElementAt(0).Defense + lord.Salubrity;
            lord.Tactics = Tactics.Aggressive;
            lord.Health = 66666;

            lord.CriticalHitRate = CalculateCritRate(lord.Vision, lord.Agility, lord.Luck, lord.Attack, lord.Type);
            lord.Items = new List<Item>();
            lord.Abilities = new List<Ability>();

            return lord;
        }

        private double CalculateCritRate(int vision, int agility, int luck, int attack, DemonType type)
        {
            double critRate = (vision + agility + luck + attack) / 4;
            int maxCritRate = 0;

            switch (type)
            {
                case DemonType.Damned:
                    maxCritRate = 33;
                    break;
                case DemonType.Soldier:
                    maxCritRate = 40;
                    break;
                case DemonType.Dealer:
                    maxCritRate = 66;
                    break;
                case DemonType.Royal:
                    maxCritRate = 75;
                    break;
                case DemonType.Lord:
                    maxCritRate = 80;
                    break;
                default:
                    maxCritRate = 33;
                    break;
            }

            while(critRate > maxCritRate)
            {
                critRate /= 2;
            }

            return critRate;
        }
    }
}
