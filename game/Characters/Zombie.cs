using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game.Items;
using game.Mechanics;

namespace game.Characters
{
    enum ZombieType
    {
        Viral,
        Risen,
        Immediate,
        Cursed,
        Sleeper
    }

    internal class Zombie : Enemy
    {
        internal ZombieType Type;
        
        internal Zombie GenerateZombie(ZombieType type, string name)
        {
            switch (type)
            {
                case ZombieType.Viral:
                    return CreateNewViral(name);
                case ZombieType.Risen:
                    return CreateNewRisen(name);
                case ZombieType.Immediate:
                    return CreateNewImmediate(name);
                case ZombieType.Cursed:
                    return CreateNewCursed(name);
                case ZombieType.Sleeper:
                    return CreateNewSleeper(name);
                default:
                    return CreateNewViral(name);
            }
        }

        readonly Weapon _weaponLoadout;

        private Zombie CreateNewViral(string name)
        {
            var viral = new Zombie();

            viral.Type = ZombieType.Viral;
            viral.IsBoss = false;

            viral.Name = name;
            viral.Description = "A mortal soul infected with a necrotic virus that is consuming them slowly from the inside out.";
            viral.Race = GenerateRace();
            viral.IsLiving = false;
            viral.Class = CharacterClass.Normal;
            viral.Height = GenerateHeight(viral.Race);
            viral.Weight = GenerateWeight(viral.Race);
            viral.Age = GenerateAge(viral.Race);
            viral.Ethics = Ethics.Objectivity;
            viral.Morals = Morals.Equity;

            viral.Vision = new Random().Next(40, 81);
            viral.Agility = new Random().Next(10, 51);
            viral.Luck = new Random().Next(20, 61);
            viral.Understanding = new Random().Next(0, 31);
            viral.Empathy = new Random().Next(0, 31);
            viral.Salubrity = new Random().Next(10, 51);

            viral.Weapons = new List<Weapon>();
            viral.Weapons.Add(_weaponLoadout.Fists());
            viral.Armor = new List<Armor>();
            viral.Range = 6;
            viral.Proficiency = Proficiency.Melee;
            viral.Attack = new Random().Next(150, 201) + viral.Weapons.ElementAt(0).Damage;
            viral.Defense = 250 + viral.Salubrity;
            viral.Tactics = Tactics.Aggressive;
            viral.Health = 2500;

            viral.Items = new List<Item>();
            viral.Abilities = new List<Ability>();

            viral.CriticalHitRate = CalculateCritRate(viral.Vision, viral.Agility, viral.Luck, viral.Attack, viral.Type);

            return viral;
        }

        private Zombie CreateNewRisen(string name)
        {
            var risen = new Zombie();

            risen.Type = ZombieType.Risen;
            risen.IsBoss = false;

            risen.Name = name;
            risen.Description = "A mortal soul who has been awoken from eternal slumber by unknown forces.";
            risen.Race = GenerateRace();
            risen.IsLiving = false;
            risen.Class = CharacterClass.Normal;
            risen.Height = GenerateHeight(risen.Race);
            risen.Weight = GenerateWeight(risen.Race);
            risen.Age = GenerateAge(risen.Race);
            risen.Ethics = Ethics.Objectivity;
            risen.Morals = Morals.Equity;

            risen.Vision = new Random().Next(40, 81);
            risen.Agility = new Random().Next(10, 51);
            risen.Luck = new Random().Next(40, 81);
            risen.Understanding = new Random().Next(0, 31);
            risen.Empathy = new Random().Next(0, 31);
            risen.Salubrity = new Random().Next(10, 51);

            risen.Weapons = new List<Weapon>();
            risen.Weapons.Add(_weaponLoadout.Fists());
            risen.Armor = new List<Armor>();
            risen.Range = 6;
            risen.Proficiency = Proficiency.Melee;
            risen.Attack = new Random().Next(250, 301) + risen.Weapons.ElementAt(0).Damage;
            risen.Defense = 250 + risen.Salubrity;
            risen.Tactics = Tactics.Aggressive;
            risen.Health = 6000;

            risen.CriticalHitRate = CalculateCritRate(risen.Vision, risen.Agility, risen.Luck, risen.Attack, risen.Type);

            return risen;
        }

        private Zombie CreateNewImmediate(string name)
        {
            var immediate = new Zombie();

            immediate.Type = ZombieType.Immediate;
            immediate.IsBoss = false;

            immediate.Name = name;
            immediate.Description = "A freshly perished mortal soul that has not yet left its body.";
            immediate.Race = GenerateRace();
            immediate.IsLiving = false;
            immediate.Class = CharacterClass.Normal;
            immediate.Height = GenerateHeight(immediate.Race);
            immediate.Weight = GenerateWeight(immediate.Race);
            immediate.Age = GenerateAge(immediate.Race);
            immediate.Ethics = Ethics.Objectivity;
            immediate.Morals = Morals.Equity;

            immediate.Vision = new Random().Next(40, 81);
            immediate.Agility = new Random().Next(40, 81);
            immediate.Luck = new Random().Next(60, 91);
            immediate.Understanding = new Random().Next(20, 61);
            immediate.Empathy = new Random().Next(30, 71);
            immediate.Salubrity = new Random().Next(40, 81);

            immediate.Weapons = new List<Weapon>();
            immediate.Weapons.Add(_weaponLoadout.Fists());
            immediate.Armor = new List<Armor>();
            immediate.Range = 6;
            immediate.Proficiency = Proficiency.Melee;
            immediate.Attack = new Random().Next(500, 601) + immediate.Weapons.ElementAt(0).Damage;
            immediate.Defense = 550 + immediate.Salubrity;
            immediate.Tactics = Tactics.Aggressive;
            immediate.Health = 15000;

            immediate.CriticalHitRate = CalculateCritRate(immediate.Vision, immediate.Agility, immediate.Luck, immediate.Attack, immediate.Type);

            return immediate;
        }

        private Zombie CreateNewCursed(string name)
        {
            var cursed = new Zombie();

            cursed.Type = ZombieType.Cursed;
            cursed.IsBoss = false;

            cursed.Name = name;
            cursed.Description = "A mortal soul bound to its body after death via a horrible curse.";
            cursed.Race = GenerateRace();
            cursed.IsLiving = false;
            cursed.Class = CharacterClass.Rogue;
            cursed.Height = GenerateHeight(cursed.Race);
            cursed.Weight = GenerateWeight(cursed.Race);
            cursed.Age = GenerateAge(cursed.Race);
            cursed.Ethics = Ethics.Chicanery;
            cursed.Morals = Morals.Treachery;

            cursed.Vision = new Random().Next(40, 81);
            cursed.Agility = new Random().Next(40, 81);
            cursed.Luck = new Random().Next(40, 81);
            cursed.Understanding = new Random().Next(10, 51);
            cursed.Empathy = new Random().Next(10, 51);
            cursed.Salubrity = new Random().Next(40, 81);

            cursed.Weapons = new List<Weapon>();
            cursed.Weapons.Add(_weaponLoadout.Fists());
            cursed.Armor = new List<Armor>();
            cursed.Range = 6;
            cursed.Proficiency = Proficiency.One_Handed;
            cursed.Attack = new Random().Next(700, 801) + cursed.Weapons.ElementAt(0).Damage;
            cursed.Defense = 800 + cursed.Salubrity;
            cursed.Tactics = Tactics.Aggressive;
            cursed.Health = 40000;

            cursed.CriticalHitRate = CalculateCritRate(cursed.Vision, cursed.Agility, cursed.Luck, cursed.Attack, cursed.Type);

            return cursed;
        }

        private Zombie CreateNewSleeper(string name)
        {
            var sleeper = new Zombie();

            sleeper.Type = ZombieType.Sleeper;
            sleeper.IsBoss = true;

            sleeper.Name = name;
            sleeper.Description = "A mortal soul under the control of an unknown entity, which can be activated at will.";
            sleeper.Race = GenerateRace();
            sleeper.IsLiving = false;
            sleeper.Class = CharacterClass.Fighter;
            sleeper.Height = GenerateHeight(sleeper.Race);
            sleeper.Weight = GenerateWeight(sleeper.Race);
            sleeper.Age = GenerateAge(sleeper.Race);
            sleeper.Ethics = Ethics.Chicanery;
            sleeper.Morals = Morals.Treachery;

            sleeper.Vision = new Random().Next(50, 91);
            sleeper.Agility = new Random().Next(50, 91);
            sleeper.Luck = new Random().Next(40, 81);
            sleeper.Understanding = new Random().Next(20, 61);
            sleeper.Empathy = new Random().Next(0, 31);
            sleeper.Salubrity = new Random().Next(40, 81);

            sleeper.Weapons = new List<Weapon>();
            sleeper.Weapons.Add(_weaponLoadout.Fists());
            sleeper.Armor = new List<Armor>();
            sleeper.Range = 6;
            sleeper.Proficiency = Proficiency.One_Handed;
            sleeper.Attack = new Random().Next(1000, 1201) + sleeper.Weapons.ElementAt(0).Damage;
            sleeper.Defense = 1100 + sleeper.Salubrity;
            sleeper.Tactics = Tactics.Aggressive;
            sleeper.Health = 60000;

            sleeper.CriticalHitRate = CalculateCritRate(sleeper.Vision, sleeper.Agility, sleeper.Luck, sleeper.Attack, sleeper.Type);

            return sleeper;
        }

        private double CalculateCritRate(int vision, int agility, int luck, int attack, ZombieType type)
        {
            double critRate = (vision + agility + luck + attack) / 4;
            int maxCritRate = 0;
            switch (type)
            {
                case ZombieType.Viral:
                    maxCritRate = 33;
                    break;
                case ZombieType.Risen:
                    maxCritRate = 50;
                    break;
                case ZombieType.Immediate:
                    maxCritRate = 66;
                    break;
                case ZombieType.Cursed:
                    maxCritRate = 80;
                    break;
                case ZombieType.Sleeper:
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
