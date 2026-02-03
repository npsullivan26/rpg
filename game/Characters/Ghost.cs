using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using game.Items;
using game.Mechanics;

namespace game.Characters
{
    enum GhostType
    {
        Natural,
        Accidental,
        Grudge,
        Murdered,
        Possessor
    }
    internal class Ghost : Enemy
    {
        internal GhostType Type;

        internal Ghost GenerateGhost(GhostType type, string name)
        {
            switch (type)
            {
                case GhostType.Natural:
                    return CreateNewNatural(name);
                case GhostType.Accidental:
                    return CreateNewAccidental(name);
                case GhostType.Grudge:
                    return CreateNewGrudge(name);
                case GhostType.Murdered:
                    return CreateNewMurdered(name);
                case GhostType.Possessor:
                    return CreateNewPossessor(name);
                default:
                    return CreateNewNatural(name);
            }
        }

        readonly Ability _abilityLoadout;

        private Ghost CreateNewNatural(string name)
        {
            var natural = new Ghost();

            natural.Type = GhostType.Natural;
            natural.IsBoss = false;

            natural.Name = name;
            natural.Description = "A mortal soul, dead of natural causes, who is trapped in the realm of the living.";
            natural.Race = GenerateRace();
            natural.IsLiving = false;
            natural.Class = CharacterClass.Psychic;
            natural.Height = GenerateHeight(natural.Race);
            natural.Weight = GenerateWeight(natural.Race);
            natural.Age = new Random().Next(1, 15001);
            natural.Ethics = Ethics.Objectivity;
            natural.Morals = Morals.Equity;

            natural.Vision = new Random().Next(40, 81);
            natural.Agility = new Random().Next(40, 81);
            natural.Luck = new Random().Next(40, 81);
            natural.Understanding = new Random().Next(10, 51);
            natural.Empathy = new Random().Next(0, 31);
            natural.Salubrity = new Random().Next(30, 71);

            natural.Weapons = new List<Weapon>();
            natural.Armor = new List<Armor>();
            natural.Range = 0;
            natural.Proficiency = Proficiency.Psychic;
            natural.Attack = new Random().Next(100, 131);
            natural.Defense = 75 + natural.Salubrity;
            natural.Tactics = Tactics.Stealthy;
            natural.Health = 1000;

            natural.Items = new List<Item>();
            natural.Abilities = new List<Ability>();

            natural.CriticalHitRate = CalculateCritRate(natural.Vision, natural.Agility, natural.Luck, natural.Attack, natural.Type);

            return natural;
        }

        private Ghost CreateNewAccidental(string name)
        {
            var accidental = new Ghost();

            accidental.Type = GhostType.Accidental;
            accidental.IsBoss = false;

            accidental.Name = name;
            accidental.Description = "A mortal soul, dead due to an accident, who is trapped in the realm of the living.";
            accidental.Race = GenerateRace();
            accidental.IsLiving = false;
            accidental.Class = CharacterClass.Psychic;
            accidental.Height = GenerateHeight(accidental.Race);
            accidental.Weight = GenerateWeight(accidental.Race);
            accidental.Age = new Random().Next(1, 15001);
            accidental.Ethics = Ethics.Objectivity;
            accidental.Morals = Morals.Equity;

            accidental.Vision = new Random().Next(40, 81);
            accidental.Agility = new Random().Next(40, 81);
            accidental.Luck = new Random().Next(10, 51);
            accidental.Understanding = new Random().Next(10, 51);
            accidental.Empathy = new Random().Next(0, 31);
            accidental.Salubrity = new Random().Next(30, 71);

            accidental.Weapons = new List<Weapon>();
            accidental.Armor = new List<Armor>();
            accidental.Range = 0;
            accidental.Proficiency = Proficiency.Psychic;
            accidental.Attack = new Random().Next(150, 201);
            accidental.Defense = 120 + accidental.Salubrity;
            accidental.Tactics = Tactics.Stealthy;
            accidental.Health = 3000;

            accidental.Items = new List<Item>();
            accidental.Abilities = new List<Ability>();

            accidental.CriticalHitRate = CalculateCritRate(accidental.Vision, accidental.Agility, accidental.Luck, accidental.Attack, accidental.Type);

            return accidental;
        }

        private Ghost CreateNewGrudge(string name)
        {
            var grudge = new Ghost();

            grudge.Type = GhostType.Grudge;
            grudge.IsBoss = false;

            grudge.Name = name;
            grudge.Description = "A departed mortal soul with unfinished business in the realm of the living.";
            grudge.Race = GenerateRace();
            grudge.IsLiving = false;
            grudge.Class = CharacterClass.Psychic;
            grudge.Height = GenerateHeight(grudge.Race);
            grudge.Weight = GenerateWeight(grudge.Race);
            grudge.Age = new Random().Next(1, 15001);
            grudge.Ethics = Ethics.Chicanery;
            grudge.Morals = Morals.Treachery;

            grudge.Vision = new Random().Next(40, 81);
            grudge.Agility = new Random().Next(40, 81);
            grudge.Luck = new Random().Next(40, 81);
            grudge.Understanding = new Random().Next(50, 91);
            grudge.Empathy = new Random().Next(0, 31);
            grudge.Salubrity = new Random().Next(30, 71);

            grudge.Weapons = new List<Weapon>();
            grudge.Armor = new List<Armor>();
            grudge.Range = 0;
            grudge.Proficiency = Proficiency.Psychic;
            grudge.Attack = new Random().Next(200, 251);
            grudge.Defense = 175 + grudge.Salubrity;
            grudge.Tactics = Tactics.Stealthy;
            grudge.Health = 7500;

            grudge.Items = new List<Item>();
            grudge.Abilities = new List<Ability>();

            grudge.CriticalHitRate = CalculateCritRate(grudge.Vision, grudge.Agility, grudge.Luck, grudge.Attack, grudge.Type);

            return grudge;
        }

        private Ghost CreateNewMurdered(string name)
        {
            var murdered = new Ghost();

            murdered.Type = GhostType.Murdered;
            murdered.IsBoss = false;

            murdered.Name = name;
            murdered.Description = "A mortal soul who was the victim of a murder and now seeks revenge in the realm of the living.";
            murdered.Race = GenerateRace();
            murdered.IsLiving = false;
            murdered.Class = CharacterClass.Psychic;
            murdered.Height = GenerateHeight(murdered.Race);
            murdered.Weight = GenerateWeight(murdered.Race);
            murdered.Age = new Random().Next(1, 15001);
            murdered.Ethics = Ethics.Chicanery;
            murdered.Morals = Morals.Treachery;

            murdered.Vision = new Random().Next(40, 81);
            murdered.Agility = new Random().Next(40, 81);
            murdered.Luck = new Random().Next(10, 51);
            murdered.Understanding = new Random().Next(60, 101);
            murdered.Empathy = new Random().Next(0, 31);
            murdered.Salubrity = new Random().Next(30, 71);

            murdered.Weapons = new List<Weapon>();
            murdered.Armor = new List<Armor>();
            murdered.Range = 0;
            murdered.Proficiency = Proficiency.Psychic;
            murdered.Attack = new Random().Next(400, 501);
            murdered.Defense = 250 + murdered.Salubrity;
            murdered.Tactics = Tactics.Stealthy;
            murdered.Health = 15000;

            murdered.Items = new List<Item>();
            murdered.Abilities = new List<Ability>();

            murdered.CriticalHitRate = CalculateCritRate(murdered.Vision, murdered.Agility, murdered.Luck, murdered.Attack, murdered.Type);

            return murdered;
        }

        private Ghost CreateNewPossessor(string name)
        {
            var possessor = new Ghost();

            possessor.Type = GhostType.Possessor;
            possessor.IsBoss = true;

            possessor.Name = name;
            possessor.Description = "A departed mortal soul who, in a desperate attempt to feel alive again, has learned to possess the bodies of living beings.";
            possessor.Race = GenerateRace();
            possessor.IsLiving = false;
            possessor.Class = CharacterClass.Psychic;
            possessor.Height = GenerateHeight(possessor.Race);
            possessor.Weight = GenerateWeight(possessor.Race);
            possessor.Age = new Random().Next(100, 15001);
            possessor.Ethics = Ethics.Chicanery;
            possessor.Morals = Morals.Equity;

            possessor.Vision = new Random().Next(40, 81);
            possessor.Agility = new Random().Next(40, 81);
            possessor.Luck = new Random().Next(40, 81);
            possessor.Understanding = new Random().Next(80, 101);
            possessor.Empathy = new Random().Next(0, 31);
            possessor.Salubrity = new Random().Next(30, 71);

            possessor.Weapons = new List<Weapon>();
            possessor.Armor = new List<Armor>();
            possessor.Range = 0;
            possessor.Proficiency = Proficiency.Psychic;
            possessor.Attack = new Random().Next(1000, 1501);
            possessor.Defense = 750 + possessor.Salubrity;
            possessor.Tactics = Tactics.Stealthy;
            possessor.Health = 30000;

            possessor.CriticalHitRate = CalculateCritRate(possessor.Vision, possessor.Agility, possessor.Luck, possessor.Attack, possessor.Type);
            possessor.Items = new List<Item>();
            possessor.Abilities.Add(_abilityLoadout.GhostPossession(possessor.CriticalHitRate));

            return possessor;
        }

        private double CalculateCritRate(int vision, int agility, int luck, int attack, GhostType type)
        {
            double critRate = (vision + agility + luck + attack) / 4;
            int maxCritRate = 0;
            switch (type)
            {
                case GhostType.Natural:
                    maxCritRate = 33;
                    break;
                case GhostType.Accidental:
                    maxCritRate = 40;
                    break;
                case GhostType.Grudge:
                    maxCritRate = 55;
                    break;
                case GhostType.Murdered:
                    maxCritRate = 70;
                    break;
                case GhostType.Possessor:
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
