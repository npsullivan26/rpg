using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game.Items;
using game.Mechanics;

namespace game.Characters
{
    enum Ethics
    {
        Rigidity,
        Objectivity,
        Chicanery
    }

    enum Morals
    {
        Piety,
        Equity,
        Treachery
    }

    enum Proficiency
    {
        Marksmanship,
        Melee,
        One_Handed,
        Psychic,
        Ranged,
        Two_Handed
    }

    enum Tactics
    {
        Stealthy,
        Aggressive,
        Defensive,
        Symbiotic
    }

    enum Race
    {
        Angel,
        Nephilim,
        Demon,
        Cambion,
        Dwarf,
        Half_Dwarf,
        Elf,
        Half_Elf,
        Human,
        Ghost,
        Possessed,
        Zombie
    }

    enum CharacterClass
    {
        Normal,
        Fighter,
        Knight,
        Rogue,
        Noble,
        Psychic
    }

    internal class Character
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal Race Race { get; set; }
        internal CharacterClass Class { get; set; }
        internal bool IsLiving { get; set; }
        internal int Height { get; set; }
        internal int Weight { get; set; }
        internal int Age { get; set; }

        internal Ethics Ethics { get; set; }
        internal Morals Morals { get; set; }

        internal int Vision { get; set; }
        internal int Agility { get; set; }
        internal int Luck {  get; set; }
        internal int Understanding { get; set; }
        internal int Empathy { get; set; }
        internal int Salubrity { get; set; }

        internal double CriticalHitRate { get; set; }

        internal List<Weapon> Weapons { get; set; }
        internal Weapon CurrentWeapon { get; set; }
        internal List<Armor> Armor { get; set; }
        internal int Range { get; set; }
        internal Proficiency Proficiency { get; set; }
        internal int Attack { get; set; }
        internal int Defense { get; set; }
        internal Tactics Tactics { get; set; }
        internal int Health { get; set; }

        internal List<Item> Items { get; set; }
        internal List<Ability> Abilities { get; set; }

        internal Race GenerateRace()
        {
            var races = Enum.GetValues(typeof(Race));
            int selector = new Random().Next(4, 9);
            return (Race)races.GetValue(selector);
        }

        internal int GenerateHeight(Race race)
        {
            switch (race)
            {
                case Race.Dwarf:
                    return new Random().Next(30, 61);
                case Race.Half_Dwarf:
                    return new Random().Next(40, 67);
                case Race.Elf:
                    return new Random().Next(54, 97);
                case Race.Half_Elf:
                    return new Random().Next(48, 91);
                case Race.Human:
                    return new Random().Next(48, 91);
                default:
                    return new Random().Next(30, 97);
            }
        }

        internal int GenerateWeight(Race race)
        {
            switch (race)
            {
                case Race.Dwarf:
                    return new Random().Next(75, 251);
                case Race.Half_Dwarf:
                    return new Random().Next(75, 251);
                case Race.Elf:
                    return new Random().Next(100, 351);
                case Race.Half_Elf:
                    return new Random().Next(80, 251);
                case Race.Human:
                    return new Random().Next(80, 351);
                default:
                    return new Random().Next(75, 351);
            }
        }

        internal int GenerateAge(Race race)
        {
            switch (race)
            {
                case Race.Dwarf:
                    return new Random().Next(20, 201);
                case Race.Half_Dwarf:
                    return new Random().Next(18, 121);
                case Race.Elf:
                    return new Random().Next(30, 401);
                case Race.Half_Elf:
                    return new Random().Next(18, 201);
                case Race.Human:
                    return new Random().Next(18, 101);
                default:
                    return new Random().Next(18, 121);
            }
        }

        internal Ethics GenerateEthics()
        {
            var ethics = Enum.GetValues(typeof(Ethics));
            int selector = new Random().Next(0, 3);
            return (Ethics)ethics.GetValue(selector);
        }

        internal Morals GenerateMorals()
        {
            var morals = Enum.GetValues(typeof(Morals));
            int selector = new Random().Next(0, 3);
            return (Morals)morals.GetValue(selector);
        }

        internal Proficiency GenerateProficiency()
        {
            var proficiencies = Enum.GetValues(typeof(Proficiency));
            int selector = new Random().Next(0, 6);
            return (Proficiency)proficiencies.GetValue(selector);
        }

        internal Tactics GenerateTactics()
        {
            var tactics = Enum.GetValues(typeof(Tactics));
            int selector = new Random().Next(0, 4);
            return (Tactics)tactics.GetValue(selector);
        }

        internal List<Weapon> GenerateWeapons(NPCType type, string location)
        {
            var _weapon = new Weapon();
            var weapons = new List<Weapon>();
            switch (type)
            {
                case NPCType.Bartender:
                    weapons = _weapon.GenerateBartenderWeapons(location);
                    break;
                case NPCType.Townsfolk:
                    weapons = _weapon.GenerateTownsfolkWeapons(location);
                    break;
                case NPCType.Bouncer:
                    weapons = _weapon.GenerateBouncerWeapons(location);
                    break;
                case NPCType.Normal_Guard:
                    weapons = _weapon.GenerateNormalGuardWeapons(location);
                    break;
                case NPCType.Soldier:
                    weapons = _weapon.GenerateSoldierWeapons(location);
                    break;
                case NPCType.Political_Guard:
                    weapons = _weapon.GeneratePoliticalGuardWeapons(location);
                    break;
                case NPCType.Commander:
                    weapons = _weapon.GenerateCommanderWeapons(location);
                    break;
                case NPCType.Elite_Guard:
                    weapons = _weapon.GenerateEliteGuardWeapons(location);
                    break;
                case NPCType.Royal:
                    weapons = _weapon.GenerateRoyalWeapons(location);
                    break;
                case NPCType.Elite:
                    weapons = _weapon.GenerateEliteWeapons(location);
                    break;
            }
            return weapons;
        }
    }
}
