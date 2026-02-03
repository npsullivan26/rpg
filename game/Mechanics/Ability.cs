using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Mechanics
{
    internal class Ability
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int HPCostToUse { get; set; }
        internal bool IsPassive { get; set; }
        internal bool IsUsable { get; set; }
        internal bool IsInUse { get; set; }
        internal int RegenerationTime { get; set; }
        internal int SuccessChance { get; set; }

        internal Ability GhostPossession(double critRate)
        {
            var ghostPossession = new Ability();

            ghostPossession.Name = "Ghost Possession";
            ghostPossession.Description = "Allows a Possessor to gain control of a living being.";
            ghostPossession.HPCostToUse = 1500;
            ghostPossession.IsPassive = false;
            ghostPossession.IsUsable = false;
            ghostPossession.IsInUse = false;
            ghostPossession.RegenerationTime = 3;
            ghostPossession.SuccessChance = (int)Math.Round(critRate);

            return ghostPossession;
        }
    }
}
