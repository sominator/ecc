using System.Collections.Generic;

namespace ECC
{
    internal static class CharacterData
    {
        public static readonly Dictionary<string, int> NightAgentData = new Dictionary<string, int>
        {
            {"strength", 4},
            {"agility", 2},
            {"will", 2},
            {"personality", 0},
            {"athletics", 6},
            {"awareness", 2},
            {"discernment", 0},
            {"drama", 0},
            {"grappling", 6},
            {"hacking", 2},
            {"healing", 2},
            {"knowledge", 2},
            {"mancy", 4},
            {"nature", 0},
            {"negotiation", 0},
            {"stealth", 4},
            {"thievery", 2},
            {"tumbling", 4},
            {"vehicles", 2},
            {"initiative", 2},
            {"hp", 30},
            {"ceridium", 6},
            {"meleeAttack", 6},
            {"meleeDamageNumber", 1},
            {"meleeDamageType", 12},
            {"meleeDamageMod", 4},
            {"rangedAttack", 4},
            {"rangedDamageNumber", 1},
            {"rangedDamageType", 6},
            {"rangedDamageMod", 2},
            {"ac", 16},
            {"spellAttack", 4},
            {"dc", 12}
        };
    }
}
