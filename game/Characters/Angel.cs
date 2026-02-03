using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using game.Items;
using game.Mechanics; 

namespace game.Characters
{
    enum AngelType
    {
        Ascended,
        Soldier,
        Commander,
        Royal,
        Archangel
    }

    internal class Angel : Enemy
    {
        internal AngelType Type { get; set; }

        internal Angel GenerateAngel(AngelType type, string name)
        {
            switch (type)
            {
                case AngelType.Ascended:
                    return CreateNewAscended(name);
                case AngelType.Soldier:
                    return CreateNewSoldier(name);
                case AngelType.Commander:
                    return CreateNewCommander(name);
                case AngelType.Royal:
                    return CreateNewRoyal(name);
                case AngelType.Archangel:
                    return CreateNewArchangel(name);
                default:
                    return CreateNewAscended("Ascended");
            }
        }

        readonly Weapon _weaponLoadout;
        readonly Armor _armorLoadout;

        private Angel CreateNewAscended(string name)
        {
            var ascended = new Angel();
           
            ascended.Type = AngelType.Ascended;
            ascended.IsBoss = false;

            ascended.Name = name;
            ascended.Description = "A mortal soul which has ascended to the glory of heaven.";
            ascended.Race = Race.Angel;
            ascended.IsLiving = false;
            ascended.Class = CharacterClass.Fighter;
            ascended.Height = new Random().Next(30, 91);
            ascended.Weight = new Random().Next(50, 301);
            ascended.Age = new Random().Next(1, 15001);
            ascended.Ethics = Ethics.Objectivity;
            ascended.Morals = Morals.Piety;

            ascended.Vision = new Random().Next(40, 81);
            ascended.Agility = new Random().Next(40, 81);
            ascended.Luck = new Random().Next(40, 81);
            ascended.Understanding = new Random().Next(40, 81);
            ascended.Empathy = new Random().Next(60, 91);
            ascended.Salubrity = new Random().Next(50, 91);

            ascended.Weapons.Add(_weaponLoadout.CelestiumDagger());
            ascended.Weapons.Add(_weaponLoadout.Fists());
            ascended.CurrentWeapon = ascended.Weapons.ElementAt(0);
            ascended.Armor.Add(_armorLoadout.HolyRobes());
            ascended.Range = 6;
            ascended.Proficiency = Proficiency.Melee;
            ascended.Attack = new Random().Next(50, 81) + ascended.CurrentWeapon.Damage;
            ascended.Defense = 75 + ascended.Armor.ElementAt(0).Defense + ascended.Salubrity;
            ascended.Tactics = Tactics.Symbiotic;
            ascended.Health = 777;

            ascended.CriticalHitRate = CalculateCritRate(ascended.Vision, ascended.Agility, ascended.Luck, ascended.Attack, ascended.Type);
            ascended.Items = new List<Item>();
            ascended.Abilities = new List<Ability>();

            return ascended;
        }

        private Angel CreateNewSoldier(string name)
        {
            var soldier = new Angel();

            soldier.Name = name;
            soldier.Description = "A fiercely devout knight in Bunzhu's army.";
            soldier.Race = Race.Angel;
            soldier.IsLiving = false;
            soldier.Class = CharacterClass.Knight;
            soldier.Height = new Random().Next(60, 91);
            soldier.Weight = new Random().Next(120, 351);
            soldier.Age = new Random().Next(20, 15001);
            soldier.Ethics = Ethics.Rigidity;
            soldier.Morals = Morals.Piety;

            soldier.Vision = new Random().Next(60, 91);
            soldier.Agility = new Random().Next(60, 91);
            soldier.Luck = new Random().Next(40, 81);
            soldier.Understanding = new Random().Next(50, 81);
            soldier.Empathy = new Random().Next(10, 51);
            soldier.Salubrity = new Random().Next(60, 91);

            soldier.Weapons.Add(_weaponLoadout.CelestiumLance());
            soldier.Weapons.Add(_weaponLoadout.Fists());
            soldier.CurrentWeapon = soldier.Weapons.ElementAt(0);
            soldier.Armor.Add(_armorLoadout.CelestiumChainMail());
            soldier.Range = 20;
            soldier.Proficiency = Proficiency.Two_Handed;
            soldier.Attack = new Random().Next(130, 161) + soldier.CurrentWeapon.Damage;
            soldier.Defense = 150 + soldier.Armor.ElementAt(0).Defense + soldier.Salubrity;
            soldier.Tactics = Tactics.Symbiotic;
            soldier.Health = 4444;

            soldier.CriticalHitRate = CalculateCritRate(soldier.Vision, soldier.Agility, soldier.Luck, soldier.Attack, soldier.Type);
            soldier.Items = new List<Item>();
            soldier.Abilities = new List<Ability>();

            return soldier;
        }

        private Angel CreateNewCommander(string name)
        {
            var commander = new Angel();

            commander.Type = AngelType.Commander;
            commander.IsBoss = false;

            commander.Name = name;
            commander.Description = "A high-ranking official in Bunzhu's army.";
            commander.Race = Race.Angel;
            commander.IsLiving = false;
            commander.Class = CharacterClass.Knight;
            commander.Height = new Random().Next(60, 91);
            commander.Weight = new Random().Next(120, 301);
            commander.Age = new Random().Next(50, 15001);
            commander.Ethics = Ethics.Rigidity;
            commander.Morals = Morals.Piety;

            commander.Vision = new Random().Next(70, 91);
            commander.Agility = new Random().Next(70, 91);
            commander.Luck = new Random().Next(40, 81);
            commander.Understanding = new Random().Next(70, 91);
            commander.Empathy = new Random().Next(20, 61);
            commander.Salubrity = new Random().Next(70, 91);

            commander.Weapons.Add(_weaponLoadout.CelestiumSword());
            commander.Weapons.Add(_weaponLoadout.Fists());
            commander.CurrentWeapon = commander.Weapons.ElementAt(0);
            commander.Armor.Add(_armorLoadout.CelestiumShield());
            commander.Armor.Add(_armorLoadout.CelestiumPlateMail());
            commander.Range = 15;
            commander.Proficiency = Proficiency.One_Handed;
            commander.Attack = new Random().Next(250, 301) + commander.CurrentWeapon.Damage;
            commander.Defense = 300 + commander.Armor.ElementAt(0).Defense + commander.Armor.ElementAt(1).Defense + commander.Salubrity;
            commander.Tactics = Tactics.Symbiotic;
            commander.Health = 7777;

            commander.CriticalHitRate = CalculateCritRate(commander.Vision, commander.Agility, commander.Luck, commander.Attack, commander.Type);
            commander.Items = new List<Item>();
            commander.Abilities = new List<Ability>();

            return commander;
        }

        private Angel CreateNewRoyal(string name)
        {
            var royal = new Angel();

            royal.Type = AngelType.Royal;
            royal.IsBoss = true;

            royal.Name = name;
            royal.Description = "One of Bunzhu's most trusted subordinates; truly a force to be reckoned with.";
            royal.Race = Race.Angel;
            royal.IsLiving = false;
            royal.Class = CharacterClass.Noble;
            royal.Height = new Random().Next(120, 181);
            royal.Weight = new Random().Next(300, 601);
            royal.Age = new Random().Next(500, 15001);
            royal.Ethics = Ethics.Rigidity;
            royal.Morals = Morals.Piety;

            royal.Vision = new Random().Next(75, 101);
            royal.Agility = new Random().Next(75, 101);
            royal.Luck = new Random().Next(50, 101);
            royal.Understanding = new Random().Next(70, 101);
            royal.Empathy = new Random().Next(50, 91);
            royal.Salubrity = new Random().Next(75, 101);

            royal.Weapons.Add(_weaponLoadout.CelestiumTriBolt());
            royal.Weapons.Add(_weaponLoadout.Fists());
            royal.CurrentWeapon = royal.Weapons.ElementAt(0);
            royal.Armor.Add(_armorLoadout.CelestiumPlateMail());
            royal.Range = 150;
            royal.Proficiency = Proficiency.Ranged;
            royal.Attack = new Random().Next(500, 601) + royal.CurrentWeapon.Damage;
            royal.Defense = 300 + royal.Armor.ElementAt(0).Defense + royal.Salubrity;
            royal.Tactics = Tactics.Symbiotic;
            royal.Health = 17777;

            royal.CriticalHitRate = CalculateCritRate(royal.Vision, royal.Agility, royal.Luck, royal.Attack, royal.Type);
            royal.Items = new List<Item>();
            royal.Abilities = new List<Ability>();

            return royal;
        }

        private Angel CreateNewArchangel(string name)
        {
            var archangel = new Angel();

            archangel.Type = AngelType.Archangel;
            archangel.IsBoss = true;

            archangel.Name = name;
            archangel.Description = "An extremely powerful member of the Holy Host of Bunzhu.";
            archangel.Race = Race.Angel;
            archangel.IsLiving = false;
            archangel.Class = CharacterClass.Noble;
            archangel.Height = new Random().Next(150, 241);
            archangel.Weight = new Random().Next(600, 1201);
            archangel.Age = new Random().Next(5000, 15001);
            archangel.Ethics = Ethics.Rigidity;
            archangel.Morals = Morals.Piety;

            archangel.Vision = new Random().Next(80, 101);
            archangel.Agility = new Random().Next(80, 101);
            archangel.Luck = new Random().Next(80, 101);
            archangel.Understanding = new Random().Next(80, 101);
            archangel.Empathy = new Random().Next(80, 101);
            archangel.Salubrity = new Random().Next(80, 101);

            archangel.Weapons.Add(_weaponLoadout.CelestiumWhip());
            archangel.Weapons.Add(_weaponLoadout.CelestiumFlail());
            archangel.Weapons.Add(_weaponLoadout.Fists());
            archangel.CurrentWeapon = archangel.Weapons.ElementAt(0);
            archangel.Armor.Add(_armorLoadout.HolyMagickCelestiumPlateMail());
            archangel.Range = 50;
            archangel.Proficiency = Proficiency.One_Handed;
            archangel.Attack = new Random().Next(1500, 1601) + archangel.CurrentWeapon.Damage;
            archangel.Defense = 2000 + archangel.Armor.ElementAt(0).Defense + archangel.Salubrity;
            archangel.Tactics = Tactics.Symbiotic;
            archangel.Health = 77777;

            archangel.CriticalHitRate = CalculateCritRate(archangel.Vision, archangel.Agility, archangel.Luck, archangel.Attack, archangel.Type);
            archangel.Items = new List<Item>();
            archangel.Abilities = new List<Ability>();

            return archangel;
        }

        private double CalculateCritRate(int vision, int agility, int luck, int attack, AngelType type)
        {
            double critRate = (vision + agility + luck + attack) / 4;
            int maxCritRate = 0;
            switch (type)
            {
                case AngelType.Ascended:
                    maxCritRate = 33;
                    break;
                case AngelType.Soldier:
                    maxCritRate = 40;
                    break;
                case AngelType.Commander:
                    maxCritRate = 50;
                    break;
                case AngelType.Royal:
                    maxCritRate = 75;
                    break;
                case AngelType.Archangel:
                    maxCritRate = 90;
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
