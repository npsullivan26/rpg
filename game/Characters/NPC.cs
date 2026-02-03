using game.Items;
using game.Mechanics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace game.Characters
{
    enum NPCType
    {
        Bartender,
        Townsfolk,
        Bouncer,
        Normal_Guard,
        Soldier,
        Political_Guard,
        Commander,
        Elite_Guard,
        Royal,
        Elite
    }
    internal class NPC : Character
    {
        internal NPCType Type { get; set; }

        internal NPC GenerateNPC(NPCType type, string name, string location)
        {
            switch (type)
            {
                case NPCType.Bartender:
                    return CreateNewBartender(name, location);
                case NPCType.Townsfolk:
                    return CreateNewTownsfolk(name, location);
                case NPCType.Bouncer:
                    return CreateNewBouncer(name, location);
                case NPCType.Normal_Guard:
                    return CreateNewNormalGuard(name, location);
                case NPCType.Soldier:
                    return CreateNewSoldier(name, location);
                case NPCType.Political_Guard:
                    return CreateNewPoliticalGuard(name, location);
                case NPCType.Commander:
                    return CreateNewCommander(name, location);
                case NPCType.Elite_Guard:
                    return CreateNewEliteGuard(name, location);
                case NPCType.Royal:
                    return CreateNewRoyal(name, location);
                case NPCType.Elite:
                    return CreateNewElite(name, location);
                default:
                    return CreateNewTownsfolk(name, location);
            }
        }

        readonly Weapon _weaponLoadout;
        readonly Armor _armorLoadout;
        readonly Ability _abilityLoadout;

        private NPC CreateNewBartender(string name, string location)
        {
            var bartender = new NPC();

            bartender.Type = NPCType.Bartender;

            bartender.Name = name;
            bartender.Description = $"A real salt-of-the-earth worker. A friend of the people of {location} and an enemy of thirst.";
            bartender.Race = GenerateRace();
            bartender.IsLiving = true;
            bartender.Class = CharacterClass.Normal;
            bartender.Height = GenerateHeight(bartender.Race);
            bartender.Weight = GenerateWeight(bartender.Race);
            bartender.Age = GenerateAge(bartender.Race);
            bartender.Ethics = Ethics.Objectivity;
            bartender.Morals = Morals.Equity;

            bartender.Vision = new Random().Next(40, 81);
            bartender.Agility = new Random().Next(40, 81);
            bartender.Luck = new Random().Next(50, 91);
            bartender.Understanding = new Random().Next(50, 91);
            bartender.Empathy = new Random().Next(60, 101);
            bartender.Salubrity = new Random().Next(40, 81);

            bartender.Weapons = GenerateWeapons(bartender.Type, location);
            bartender.CurrentWeapon = bartender.Weapons.ElementAt(0);
            bartender.Armor = new List<Armor>();
            bartender.Range = 10;
            bartender.Proficiency = Proficiency.One_Handed;
            bartender.Attack = new Random().Next(300, 401) + bartender.CurrentWeapon.Damage;
            bartender.Defense = 350 + bartender.Salubrity;
            bartender.Tactics = Tactics.Defensive;
            bartender.Health = new Random().Next(3000, 5001) + bartender.Salubrity;

            bartender.CriticalHitRate = CalculateCritRate(bartender.Vision, bartender.Agility, bartender.Luck, bartender.Attack, bartender.Type);

            return bartender;
        }

        private NPC CreateNewTownsfolk(string name, string location)
        {
            var townsfolk = new NPC();

            townsfolk.Type = NPCType.Townsfolk;

            townsfolk.Name = name;
            townsfolk.Description = $"A resident of {location}.";
            townsfolk.Race = GenerateRace();
            townsfolk.IsLiving = true;
            townsfolk.Class = CharacterClass.Normal;
            townsfolk.Height = GenerateHeight(townsfolk.Race);
            townsfolk.Weight = GenerateWeight(townsfolk.Race);
            townsfolk.Age = GenerateAge(townsfolk.Race);
            townsfolk.Ethics = GenerateEthics();
            townsfolk.Morals = GenerateMorals();

            townsfolk.Vision = new Random().Next(0, 101);
            townsfolk.Agility = new Random().Next(0, 101);
            townsfolk.Luck = new Random().Next(0, 101);
            townsfolk.Understanding = new Random().Next(0, 101);
            townsfolk.Empathy = new Random().Next(0, 101);
            townsfolk.Salubrity = new Random().Next(0, 101);

            townsfolk.Weapons = GenerateWeapons(townsfolk.Type, location);
            townsfolk.CurrentWeapon = townsfolk.Weapons.ElementAt(0);
            townsfolk.Armor = new List<Armor>();
            townsfolk.Range = 10;
            townsfolk.Proficiency = GenerateProficiency();
            townsfolk.Attack = new Random().Next(250, 301) + townsfolk.CurrentWeapon.Damage;
            townsfolk.Defense = new Random().Next(200, 301) + townsfolk.Salubrity;
            townsfolk.Tactics = GenerateTactics();
            townsfolk.Health = new Random().Next(3000, 5001);

            townsfolk.CriticalHitRate = CalculateCritRate(townsfolk.Vision, townsfolk.Agility, townsfolk.Luck, townsfolk.Attack, townsfolk.Type);

            return townsfolk;
        }



        private double CalculateCritRate(int vision, int agility, int luck, int attack, NPCType type)
        {
            double critRate = (vision + agility + luck + attack) / 4;
            int maxCritRate = 0;
            switch (type)
            {
                case NPCType.Bartender:
                    maxCritRate = 50;
                    break;
                case NPCType.Townsfolk:
                    maxCritRate = 33;
                    break;
                case NPCType.Bouncer:
                    maxCritRate = 60;
                    break;
                case NPCType.Normal_Guard:
                    maxCritRate = 66;
                    break;
                case NPCType.Soldier:
                    maxCritRate = 66;
                    break;
                case NPCType.Commander:
                    maxCritRate = 75;
                    break;
                case NPCType.Elite_Guard:
                    maxCritRate = 80;
                    break;
                case NPCType.Royal:
                    maxCritRate = 90;
                    break;
                case NPCType.Elite:
                    maxCritRate = 95;
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
