using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Items
{
    enum ArmorType
    {
        Helmet,
        Body,
        Arms,
        Legs,
        Shield
    }
    internal class Armor
    {
        internal ArmorType Type { get; set; }
        internal string Name { get; set; }
        internal int Defense { get; set; }

        internal Armor() { }
        internal Armor(ArmorType type, string name, int defense)
        {
            Type = type;
            Name = name;
            Defense = defense;
        }

        // Demon Armor
        internal Armor UnholyRobes()
        {
            return new Armor(ArmorType.Body, "Unholy Robes", 25);
        }
        internal Armor InfernumChainMail()
        {
            return new Armor(ArmorType.Body, "Infernum Chain Main", 50);
        }
        internal Armor InfernumShield()
        {
            return new Armor(ArmorType.Shield, "Infernum Shield", 50);
        }
        internal Armor InfernumPlateMail()
        {
            return new Armor(ArmorType.Body, "Infernum Plate Mail", 100);
        }
        internal Armor DarkMagickInfernumPlateMail()
        {
            return new Armor(ArmorType.Body, "Dark Magick Infernum Plate Mail", 500);
        }

        // Angel Armor
        internal Armor HolyRobes()
        {
            return new Armor(ArmorType.Body, "Holy Robes", 25);
        }
        internal Armor CelestiumChainMail()
        {
            return new Armor(ArmorType.Body, "Celestium Chain Mail", 50);
        }
        internal Armor CelestiumShield()
        {
            return new Armor(ArmorType.Shield, "Celestium Shield", 50);
        }
        internal Armor CelestiumPlateMail()
        {
            return new Armor(ArmorType.Body, "Celestium Plate Mail", 100);
        }
        internal Armor HolyMagickCelestiumPlateMail()
        {
            return new Armor(ArmorType.Body, "Holy Magick Celestium Plate Mail", 500);
        }
    }
}
