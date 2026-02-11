using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
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
            // Bartender Special
        internal Weapon ChefsKnife()
        {
            return new Weapon(WeaponType.One_Handed, "Chef's Knife", 40);
        }
            // The Blythewoods
        internal Weapon Dagger()
        {
            return new Weapon(WeaponType.One_Handed, "Dagger", 25);
        }
        internal Weapon ThrowingKnife()
        {
            return new Weapon(WeaponType.Ranged, "Throwing Knife", 40);
        }
                // Townsfolk Special
        internal Weapon Bow()
        {
            return new Weapon(WeaponType.Ranged, "Bow", 60);
        }
                // Bouncer Special
        internal Weapon Gauntlets()
        {
            return new Weapon(WeaponType.Melee, "Gauntlets", 45);
        }
                // Normal Guard Special
        internal Weapon Spear()
        {
            return new Weapon(WeaponType.One_Handed, "Spear", 60);
        }
            // Malagantu
        internal Weapon Bonesaw()
        {
            return new Weapon(WeaponType.One_Handed, "Bonesaw", 60);
        }
        internal Weapon Boomerang()
        {
            return new Weapon(WeaponType.Ranged, "Boomerang", 50);
        }
                // Townsfolk Special
        internal Weapon Scimitar()
        {
            return new Weapon(WeaponType.One_Handed, "Scimitar", 65);
        }
                // Bouncer Special
        internal Weapon SpikedClub() {
            return new Weapon(WeaponType.One_Handed, "Spiked Club", 50);
        }
                // Normal Guard Special
        internal Weapon Longsword()
        {
            return new Weapon(WeaponType.Two_Handed, "Longsword", 100);
        }
            // Nyborg
        internal Weapon BrassKnuckles()
        {
            return new Weapon(WeaponType.Melee, "Brass Knuckles", 35);
        }
        internal Weapon Pistol()
        {
            return new Weapon(WeaponType.Gun, "Pistol", 75);
        }
                // Townsfolk Special
        internal Weapon Grenade()
        {
            return new Weapon(WeaponType.Ranged, "Grenade", 100);
        }
                // Bouncer Special
        internal Weapon SpikedGauntlets()
        {
            return new Weapon(WeaponType.Melee, "Spiked Gauntlets", 90);
        }
                // Normal Guard Special
        internal Weapon Rifle()
        {
            return new Weapon(WeaponType.Gun, "Rifle", 150);
        }
            // Santtengah
        internal Weapon ShortSword()
        {
            return new Weapon(WeaponType.One_Handed, "Short Sword", 50);
        }
        internal Weapon Baton()
        {
            return new Weapon(WeaponType.One_Handed, "Baton", 35);
        }
                // Townsfolk Special
        internal Weapon Shotgun()
        {
            return new Weapon(WeaponType.Gun, "Shotgun", 125);
        }
                // Bouncer Special
        internal Weapon SpikedChain()
        {
            return new Weapon(WeaponType.Ranged, "Spiked Chain", 85);
        }
                // Normal Guard Special
        internal Weapon Tribolt()
        {
            return new Weapon(WeaponType.Ranged, "Tri-Bolt", 125);
        }
            // Zerua
        internal Weapon Crossbow()
        {
            return new Weapon(WeaponType.Ranged, "Crossbow", 65);
        }
        internal Weapon ChainWhip()
        {
            return new Weapon(WeaponType.Ranged, "Chain Whip", 55);
        }
                // Townsfolk Special
        internal Weapon Longbow()
        {
            return new Weapon(WeaponType.Ranged, "Longbow", 80);
        }
                // Bouncer Special
        internal Weapon HeavyHammer()
        {
            return new Weapon(WeaponType.One_Handed, "Heavy Hammer", 75);
        }
                // Normal Guard Special
        internal Weapon Battleaxe()
        {
            return new Weapon(WeaponType.One_Handed, "Battle Axe", 90);
        }

        // Generator Methods (Bartender)
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
            weapons.Add(Fists());
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
            }
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
            }
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
            }
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
            }
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
            }
            return weapons;
        }

        // Generator Methods (Townsfolk)
        internal List<Weapon> GenerateTownsfolkWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsTownsfolkWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuTownsfolkWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgTownsfolkWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahTownsfolkWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaTownsfolkWeapons();
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateBlythewoodsTownsfolkWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Dagger());
                    break;
                case 2:
                    weapons.Add(ThrowingKnife());
                    break;
                case 3:
                    weapons.Add(Bow());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateMalagantuTownsfolkWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Bonesaw());
                    break;
                case 2:
                    weapons.Add(Boomerang());
                    break;
                case 3:
                    weapons.Add(Scimitar());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateNyborgTownsfolkWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(BrassKnuckles());
                    break;
                case 2:
                    weapons.Add(Pistol());
                    break;
                case 3:
                    weapons.Add(Grenade());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateZeruaTownsfolkWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Crossbow());
                    break;
                case 2:
                    weapons.Add(ChainWhip());
                    break;
                case 3:
                    weapons.Add(Longbow());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateSanttengahTownsfolkWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 16);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(ShortSword());
                    break;
                case 2:
                    weapons.Add(Baton());
                    break;
                case 3:
                    weapons.Add(Shotgun());
                    break;
                case 4:
                    weapons.Add(Dagger());
                    break;
                case 5:
                    weapons.Add(ThrowingKnife());
                    break;
                case 6:
                    weapons.Add(Bow());
                    break;
                case 7:
                    weapons.Add(Bonesaw());
                    break;
                case 8:
                    weapons.Add(Boomerang());
                    break;
                case 9:
                    weapons.Add(Scimitar());
                    break;
                case 10:
                    weapons.Add(BrassKnuckles());
                    break;
                case 11:
                    weapons.Add(Pistol());
                    break;
                case 12:
                    weapons.Add(Grenade());
                    break;
                case 13:
                    weapons.Add(Crossbow());
                    break;
                case 14:
                    weapons.Add(ChainWhip());
                    break;
                case 15:
                    weapons.Add(Longbow());
                    break;
            }
            return weapons;
        }

        // Generator Methods (Bouncer)
        internal List<Weapon> GenerateBouncerWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsBouncerWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuBouncerWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgBouncerWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahBouncerWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaBouncerWeapons();
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateBlythewoodsBouncerWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Dagger());
                    break;
                case 2:
                    weapons.Add(ThrowingKnife());
                    break;
                case 3:
                    weapons.Add(Gauntlets());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateMalagantuBouncerWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Bonesaw());
                    break;
                case 2:
                    weapons.Add(Boomerang());
                    break;
                case 3:
                    weapons.Add(SpikedClub());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateNyborgBouncerWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(BrassKnuckles());
                    break;
                case 2:
                    weapons.Add(Pistol());
                    break;
                case 3:
                    weapons.Add(SpikedGauntlets());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateZeruaBouncerWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Crossbow());
                    break;
                case 2:
                    weapons.Add(ChainWhip());
                    break;
                case 3:
                    weapons.Add(HeavyHammer());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateSanttengahBouncerWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 16);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Dagger());
                    break;
                case 2:
                    weapons.Add(ThrowingKnife());
                    break;
                case 3:
                    weapons.Add(Gauntlets());
                    break;
                case 4:
                    weapons.Add(Bonesaw());
                    break;
                case 5:
                    weapons.Add(Boomerang());
                    break;
                case 6:
                    weapons.Add(SpikedClub());
                    break;
                case 7:
                    weapons.Add(BrassKnuckles());
                    break;
                case 8:
                    weapons.Add(Pistol());
                    break;
                case 9:
                    weapons.Add(SpikedGauntlets());
                    break;
                case 10:
                    weapons.Add(ShortSword());
                    break;
                case 11:
                    weapons.Add(Baton());
                    break;
                case 12:
                    weapons.Add(SpikedChain());
                    break;
                case 13:
                    weapons.Add(Crossbow());
                    break;
                case 14:
                    weapons.Add(ChainWhip());
                    break;
                case 15:
                    weapons.Add(HeavyHammer());
                    break;
            }
            return weapons;
        }

        // Generator Methods (Normal Guard)
        internal List<Weapon> GenerateNormalGuardWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsNormalGuardWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuNormalGuardWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgNormalGuardWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahNormalGuardWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaNormalGuardWeapons();
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateBlythewoodsNormalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Dagger());
                    break;
                case 2:
                    weapons.Add(ThrowingKnife());
                    break;
                case 3:
                    weapons.Add(Spear());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateMalagantuNormalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Bonesaw());
                    break;
                case 2:
                    weapons.Add(Boomerang());
                    break;
                case 3:
                    weapons.Add(Longsword());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateNyborgNormalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(BrassKnuckles());
                    break;
                case 2:
                    weapons.Add(Pistol());
                    break;
                case 3:
                    weapons.Add(Rifle());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateZeruaNormalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 4);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Crossbow());
                    break;
                case 2:
                    weapons.Add(ChainWhip());
                    break;
                case 3:
                    weapons.Add(Battleaxe());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateSanttengahNormalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 16);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons.Add(Dagger());
                    break;
                case 2:
                    weapons.Add(ThrowingKnife());
                    break;
                case 3:
                    weapons.Add(Spear());
                    break;
                case 4:
                    weapons.Add(Bonesaw());
                    break;
                case 5:
                    weapons.Add(Boomerang());
                    break;
                case 6:
                    weapons.Add(Longsword());
                    break;
                case 7:
                    weapons.Add(BrassKnuckles());
                    break;
                case 8:
                    weapons.Add(Pistol());
                    break;
                case 9:
                    weapons.Add(Rifle());
                    break;
                case 10:
                    weapons.Add(ShortSword());
                    break;
                case 11:
                    weapons.Add(Baton());
                    break;
                case 12:
                    weapons.Add(Tribolt());
                    break;
                case 13:
                    weapons.Add(Crossbow());
                    break;
                case 14:
                    weapons.Add(ChainWhip());
                    break;
                case 15:
                    weapons.Add(Battleaxe());
                    break;
            }
            return weapons;
        }
    }
}
