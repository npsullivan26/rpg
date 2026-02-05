using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace game.Items
{
    enum WeaponType
    {
        Gun,
        Melee,
        One_Handed,
        Psychic,
        Ranged,
        Two_Handed
    }

    internal class Weapon
    {    
        public WeaponType Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon() { }

        public Weapon(WeaponType type, string name, int damage)
        {
            Type = type;
            Name = name;
            Damage = damage;
        }

        // Demon Weapons
        internal Weapon InfernumDagger()
        {
            return new Weapon(WeaponType.Melee, "Infernum Dagger", 25);
        }
        internal Weapon InfernumLance()
        {
            return new Weapon(WeaponType.Two_Handed, "Infernum Lance", 65);
        }
        internal Weapon InfernumSword()
        {
            return new Weapon(WeaponType.One_Handed, "Infernum Sword", 125);
        }
        internal Weapon InfernumPitchfork()
        {
            return new Weapon(WeaponType.Two_Handed, "Infernum Pitchfork", 250);
        }
        internal Weapon InfernumWhip()
        {
            return new Weapon(WeaponType.One_Handed, "Infernum Whip", 500);
        }
        internal Weapon InfernumFlail()
        {
            return new Weapon(WeaponType.One_Handed, "Infernum Flail", 600);
        }

        // Angel Weapons
        internal Weapon CelestiumDagger()
        {
            return new Weapon(WeaponType.Melee, "Celestium Dagger", 25);
        }
        internal Weapon CelestiumLance()
        {
            return new Weapon(WeaponType.Two_Handed, "Celestium Lance", 65);
        }
        internal Weapon CelestiumSword()
        {
            return new Weapon(WeaponType.One_Handed, "Celestium Sword", 125);
        }
        internal Weapon CelestiumTriBolt()
        {
            return new Weapon(WeaponType.Ranged, "Celestium Tri-Bolt", 250);
        }
        internal Weapon CelestiumWhip()
        {
            return new Weapon(WeaponType.One_Handed, "Celestium Whip", 500);
        }
        internal Weapon CelestiumFlail()
        {
            return new Weapon(WeaponType.One_Handed, "Celestium Flail", 600);
        }

        // General Weapons
        internal Weapon Fists()
        {
            return new Weapon(WeaponType.Melee, "Fists", 10);
        }
        internal Weapon ChefsKnife()
        {
            return new Weapon(WeaponType.One_Handed, "Chef's Knife", 40);
        }
        internal Weapon Dagger()
        {
            return new Weapon(WeaponType.One_Handed, "Dagger", 25);
        }
        internal Weapon ThrowingKnife()
        {
            return new Weapon(WeaponType.Ranged, "Throwing Knife", 40);
        }
        internal Weapon Bonesaw()
        {
            return new Weapon(WeaponType.One_Handed, "Bonesaw", 60);
        }
        internal Weapon Boomerang()
        {
            return new Weapon(WeaponType.Ranged, "Boomerang", 50);
        }
        internal Weapon BrassKnuckles()
        {
            return new Weapon(WeaponType.Melee, "Brass Knuckles", 35);
        }
        internal Weapon Pistol()
        {
            return new Weapon(WeaponType.Gun, "Pistol", 75);
        }
        internal Weapon ShortSword()
        {
            return new Weapon(WeaponType.One_Handed, "Short Sword", 50);
        }
        internal Weapon Baton()
        {
            return new Weapon(WeaponType.One_Handed, "Baton", 35);
        }
        internal Weapon Crossbow()
        {
            return new Weapon(WeaponType.Ranged, "Crossbow", 65);
        }
        internal Weapon ChainWhip()
        {
            return new Weapon(WeaponType.Ranged, "Chain Whip", 55);
        }

        // Generator Methods
        internal List<Weapon> GenerateBartenderWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsBartenderWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuBartenderWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgBartenderWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahBartenderWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaBartenderWeapons();
                    break;
            }
            return weapons;
        }

        private List<Weapon> GenerateBlythewoodsBartenderWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ChefsKnife());
                    break;
                case 2:
                    weapons.Add(Dagger());
                    break;
                case 3:
                    weapons.Add(ThrowingKnife());
                    break;
                default:
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateMalagantuBartenderWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ChefsKnife());
                    break;
                case 2:
                    weapons.Add(Bonesaw());
                    break;
                case 3:
                    weapons.Add(Boomerang());
                    break;
                default:
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateNyborgBartenderWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ChefsKnife());
                    break;
                case 2:
                    weapons.Add(BrassKnuckles());
                    break;
                case 3:
                    weapons.Add(Pistol());
                    break;
                default:
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateZeruaBartenderWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ChefsKnife());
                    break;
                case 2:
                    weapons.Add(ShortSword());
                    break;
                case 3:
                    weapons.Add(Crossbow());
                    break;
                default:
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateSanttengahBartenderWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 12);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ChefsKnife());
                    break;
                case 2:
                    weapons.Add(Dagger());
                    break;
                case 3:
                    weapons.Add(Bonesaw());
                    break;
                case 4:
                    weapons.Add(BrassKnuckles());
                    break;
                case 5:
                    weapons.Add(ShortSword());
                    break;
                case 6:
                    weapons.Add(Baton());
                    break;
                case 7:
                    weapons.Add(ThrowingKnife());
                    break;
                case 8:
                    weapons.Add(Boomerang());
                    break;
                case 9:
                    weapons.Add(Pistol());
                    break;
                case 10:
                    weapons.Add(Crossbow());
                    break;
                case 11:
                    weapons.Add(ChainWhip());
                    break;
                default:
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
    }
}
