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

        internal Weapon Fists()
        {
            return new Weapon(WeaponType.Melee, "Fists", 10);
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

        // NPC Weapons
        internal Weapon ChefsKnife()
        {
            return new Weapon(WeaponType.One_Handed, "Chef's Knife", 40);
        }
    }
}
