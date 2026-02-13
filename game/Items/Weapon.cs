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
                // Soldier Special
        internal Weapon Greatsword()
        {
            return new Weapon(WeaponType.Two_Handed, "Greatsword", 150);
        }
                // Political Guard Special
        internal Weapon ExplodingBolt()
        {
            return new Weapon(WeaponType.Ranged, "Exploding Bolt", 250);
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
                // Soldier Special
        internal Weapon Flail()
        {
            return new Weapon(WeaponType.Ranged, "Flail", 175);
        }
                // Political Guard Special
        internal Weapon PsychicPunch()
        {
            return new Weapon(WeaponType.Psychic, "Psychic Punch", 225);
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
                // Soldier Special
        internal Weapon SniperRifle()
        {
            return new Weapon(WeaponType.Gun, "Sniper Rifle", 250);
        }
                // Political Guard Special (low dmg but has chance to steal items/money)
        internal Weapon ThievesHook()
        {
            return new Weapon(WeaponType.Ranged, "Thieves' Hook", 120);
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
                // Soldier Special
        internal Weapon MachineGun()
        {
            return new Weapon(WeaponType.Gun, "Machine Gun", 200);
        }
                // Political Guard Special
        internal Weapon PsychicOppression()
        {
            return new Weapon(WeaponType.Psychic, "Psychic Oppression", 325);
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
                // Soldier Special
        internal Weapon Warhammer()
        {
            return new Weapon(WeaponType.Two_Handed, "Warhammer", 175);
        }
                // Political Guard Special
        internal Weapon PoisonArrow()
        {
            return new Weapon(WeaponType.Ranged, "Poison Arrow", 200);
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
            int selector = new Random().Next(0, 7);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons = GenerateBlythewoodsBartenderWeapons();
                    break;
                case 2:
                    weapons = GenerateMalagantuBartenderWeapons();
                    break;
                case 3:
                    weapons = GenerateNyborgBartenderWeapons();
                    break;
                case 4:
                    weapons = GenerateZeruaBartenderWeapons();
                    break;
                case 5:
                    weapons.Add(Crossbow());
                    break;
                case 6:
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
            int selector = new Random().Next(0, 8);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons = GenerateBlythewoodsTownsfolkWeapons();
                    break;
                case 2:
                    weapons = GenerateMalagantuTownsfolkWeapons();
                    break;
                case 3:
                    weapons = GenerateNyborgTownsfolkWeapons();
                    break;
                case 4:
                    weapons = GenerateZeruaTownsfolkWeapons();
                    break;
                case 5:
                    weapons.Add(Crossbow());
                    break;
                case 6:
                    weapons.Add(ChainWhip());
                    break;
                case 7:
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
            int selector = new Random().Next(0, 8);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons = GenerateBlythewoodsBouncerWeapons();
                    break;
                case 2:
                    weapons = GenerateMalagantuBouncerWeapons();
                    break;
                case 3:
                    weapons = GenerateNyborgBouncerWeapons();
                    break;
                case 4:
                    weapons = GenerateZeruaBouncerWeapons();
                    break;
                case 5:
                    weapons.Add(Crossbow());
                    break;
                case 6:
                    weapons.Add(ChainWhip());
                    break;
                case 7:
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
            int selector = new Random().Next(0, 8);
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    weapons = GenerateBlythewoodsNormalGuardWeapons();
                    break;
                case 2:
                    weapons = GenerateMalagantuNormalGuardWeapons();
                    break;
                case 3:
                    weapons = GenerateNyborgNormalGuardWeapons();
                    break;
                case 4:
                    weapons = GenerateZeruaNormalGuardWeapons();
                    break;
                case 5:
                    weapons.Add(Crossbow());
                    break;
                case 6:
                    weapons.Add(ChainWhip());
                    break;
                case 7:
                    weapons.Add(Battleaxe());
                    break;
            }
            return weapons;
        }

        // Generator Methods (Soldier)
        internal List<Weapon> GenerateSoldierWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsSoldierWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuSoldierWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgSoldierWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahSoldierWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaSoldierWeapons();
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateBlythewoodsSoldierWeapons()
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
                    weapons.Add(Greatsword());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateMalagantuSoldierWeapons()
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
                    weapons.Add(Flail());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateNyborgSoldierWeapons()
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
                    weapons.Add(SniperRifle());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateZeruaSoldierWeapons()
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
                    weapons.Add(Warhammer());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateSanttengahSoldierWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 8);
            switch (selector) {
                case 0:
                    break;
                case 1:
                    weapons = GenerateBlythewoodsSoldierWeapons();
                    break;
                case 2:
                    weapons = GenerateMalagantuSoldierWeapons();
                    break;
                case 3:
                    weapons = GenerateNyborgSoldierWeapons();
                    break;
                case 4:
                    weapons = GenerateZeruaSoldierWeapons();
                    break;
                case 5:
                    weapons.Add(ShortSword());
                    break;
                case 6:
                    weapons.Add(Baton());
                    break;
                case 7:
                    weapons.Add(MachineGun());
                    break;
            }
            return weapons;
        }

        // Generator Methods (Political Guard)
        internal List<Weapon> GeneratePoliticalGuardWeapons(string location)
        {
            var weapons = new List<Weapon>();
            switch (location)
            {
                case "The Blythewoods":
                    weapons = GenerateBlythewoodsPoliticalGuardWeapons();
                    break;
                case "Malagantu":
                    weapons = GenerateMalagantuPoliticalGuardWeapons();
                    break;
                case "Nyborg":
                    weapons = GenerateNyborgPoliticalGuardWeapons();
                    break;
                case "Santtengah":
                    weapons = GenerateSanttengahPoliticalGuardWeapons();
                    break;
                case "Zerua":
                    weapons = GenerateZeruaPoliticalGuardWeapons();
                    break;
            }
            weapons.Add(Fists());
            return weapons;
        }
        private List<Weapon> GenerateBlythewoodsPoliticalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 5);
            switch (selector)
            {
                case 0:
                    weapons.Add(Dagger());
                    break;
                case 1:
                    weapons.Add(Bow());
                    break;
                case 2:
                    weapons.Add(Spear());
                    break;
                case 3:
                    weapons.Add(Greatsword());
                    break;
                case 4:
                    weapons.Add(ExplodingBolt());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateMalagantuPoliticalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 5);
            switch (selector)
            {
                case 0:
                    weapons.Add(Bonesaw());
                    break;
                case 1:
                    weapons.Add(Scimitar());
                    break;
                case 2:
                    weapons.Add(Longsword());
                    break;
                case 3:
                    weapons.Add(Flail());
                    break;
                case 4:
                    weapons.Add(PsychicPunch());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateNyborgPoliticalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 5);
            switch (selector)
            {
                case 0:
                    weapons.Add(Pistol());
                    break;
                case 1:
                    weapons.Add(Grenade());
                    break;
                case 2:
                    weapons.Add(Rifle());
                    break;
                case 3:
                    weapons.Add(SniperRifle());
                    break;
                case 4:
                    weapons.Add(ThievesHook());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateZeruaPoliticalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 5);
            switch (selector)
            {
                case 0:
                    weapons.Add(Crossbow());
                    break;
                case 1:
                    weapons.Add(Longbow());
                    break;
                case 2:
                    weapons.Add(Battleaxe());
                    break;
                case 3:
                    weapons.Add(Warhammer());
                    break;
                case 4:
                    weapons.Add(PoisonArrow());
                    break;
            }
            return weapons;
        }
        private List<Weapon> GenerateSanttengahPoliticalGuardWeapons()
        {
            var weapons = new List<Weapon>();
            int selector = new Random().Next(0, 9);
            switch (selector)
            {
                case 0:
                    weapons = GenerateBlythewoodsPoliticalGuardWeapons();
                    break;
                case 1:
                    weapons = GenerateMalagantuPoliticalGuardWeapons();
                    break;
                case 2:
                    weapons = GenerateNyborgPoliticalGuardWeapons();
                    break;
                case 3:
                    weapons = GenerateZeruaPoliticalGuardWeapons();
                    break;
                case 4:
                    weapons.Add(ShortSword());
                    break;
                case 5:
                    weapons.Add(Shotgun());
                    break;
                case 6:
                    weapons.Add(Tribolt());
                    break;
                case 7:
                    weapons.Add(MachineGun());
                    break;
                case 8:
                    weapons.Add(PsychicOppression());
                    break;
            }
            return weapons;
        }

        // Generator Methods (Commander)
    }
}
