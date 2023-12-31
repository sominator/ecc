using System.Collections.Generic;

namespace ECC
{
	internal static class CharacterData
	{
		//dictionaries to store individual class data
		public static readonly Dictionary<string, int> AuromancerData = new Dictionary<string, int>
		{
			{"strength", 2},
			{"agility", 2},
			{"will", 0},
			{"personality", 4},
			{"athletics", 2},
			{"awareness", 0},
			{"discernment", 4},
			{"drama", 6},
			{"grappling", 2},
			{"hacking", 0},
			{"healing", 2},
			{"knowledge", 2},
			{"mancy", 2},
			{"nature", 4},
			{"negotiation", 6},
			{"stealth", 2},
			{"thievery", 2},
			{"tumbling", 2},
			{"vehicles", 0},
			{"initiative", 2},
			{"hp", 24},
			{"ceridium", 8},
			{"meleeAttack", 4},
			{"meleeDamageNumber", 1},
			{"meleeDamageType", 8},
			{"meleeDamageMod", 2},
			{"rangedAttack", 4},
			{"rangedDamageNumber", 1},
			{"rangedDamageType", 6},
			{"rangedDamageMod", 2},
			{"ac", 16},
			{"spellAttack", 6},
			{"dc", 14}
		};
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
		public static readonly Dictionary<string, int> RevolutionaryData = new Dictionary<string, int>
		{
			{"strength", 2},
			{"agility", 4},
			{"will", 0},
			{"personality", 2},
			{"athletics", 4},
			{"awareness", 0},
			{"discernment", 2},
			{"drama", 2},
			{"grappling", 2},
			{"hacking", 0},
			{"healing", 2},
			{"knowledge", 0},
			{"mancy", 0},
			{"nature", 2},
			{"negotiation", 4},
			{"stealth", 4},
			{"thievery", 4},
			{"tumbling", 6},
			{"vehicles", 6},
			{"initiative", 4},
			{"hp", 26},
			{"ceridium", 2},
			{"meleeAttack", 4},
			{"meleeDamageNumber", 1},
			{"meleeDamageType", 4},
			{"meleeDamageMod", 2},
			{"rangedAttack", 6},
			{"rangedDamageNumber", 1},
			{"rangedDamageType", 8},
			{"rangedDamageMod", 4},
			{"ac", 18},
			{"spellAttack", 2},
			{"dc", 10}
		};
		public static readonly Dictionary<string, int> TechnomancerData = new Dictionary<string, int>
		{
			{"strength", 0},
			{"agility", 2},
			{"will", 4},
			{"personality", 2},
			{"athletics", 0},
			{"awareness", 4},
			{"discernment", 4},
			{"drama", 2},
			{"grappling", 0},
			{"hacking", 6},
			{"healing", 4},
			{"knowledge", 6},
			{"mancy", 6},
			{"nature", 2},
			{"negotiation", 2},
			{"stealth", 2},
			{"thievery", 2},
			{"tumbling", 2},
			{"vehicles", 4},
			{"initiative", 2},
			{"hp", 24},
			{"ceridium", 10},
			{"meleeAttack", 2},
			{"meleeDamageNumber", 1},
			{"meleeDamageType", 4},
			{"meleeDamageMod", 0},
			{"rangedAttack", 4},
			{"rangedDamageNumber", 1},
			{"rangedDamageType", 6},
			{"rangedDamageMod", 2},
			{"ac", 16},
			{"spellAttack", 6},
			{"dc", 14}
		};
		public static readonly Dictionary<string, int> TerramancerData = new Dictionary<string, int>
		{
			{"strength", 0},
			{"agility", 2},
			{"will", 2},
			{"personality", 4},
			{"athletics", 0},
			{"awareness", 2},
			{"discernment", 4},
			{"drama", 4},
			{"grappling", 0},
			{"hacking", 2},
			{"healing", 4},
			{"knowledge", 4},
			{"mancy", 4},
			{"nature", 6},
			{"negotiation", 6},
			{"stealth", 2},
			{"thievery", 2},
			{"tumbling", 2},
			{"vehicles", 2},
			{"initiative", 2},
			{"hp", 24},
			{"ceridium", 10},
			{"meleeAttack", 2},
			{"meleeDamageNumber", 1},
			{"meleeDamageType", 4},
			{"meleeDamageMod", 0},
			{"rangedAttack", 4},
			{"rangedDamageNumber", 1},
			{"rangedDamageType", 6},
			{"rangedDamageMod", 2},
			{"ac", 16},
			{"spellAttack", 6},
			{"dc", 14}
		};
		public static readonly Dictionary<string, int> VanguardData = new Dictionary<string, int>
		{
			{"strength", 0},
			{"agility", 4},
			{"will", 2},
			{"personality", 2},
			{"athletics", 0},
			{"awareness", 2},
			{"discernment", 2},
			{"drama", 4},
			{"grappling", 0},
			{"hacking", 4},
			{"healing", 2},
			{"knowledge", 2},
			{"mancy", 2},
			{"nature", 2},
			{"negotiation", 2},
			{"stealth", 6},
			{"thievery", 6},
			{"tumbling", 6},
			{"vehicles", 4},
			{"initiative", 4},
			{"hp", 24},
			{"ceridium", 2},
			{"meleeAttack", 6},
			{"meleeDamageNumber", 2},
			{"meleeDamageType", 6},
			{"meleeDamageMod", 4},
			{"rangedAttack", 2},
			{"rangedDamageNumber", 1},
			{"rangedDamageType", 4},
			{"rangedDamageMod", 0},
			{"ac", 18},
			{"spellAttack", 4},
			{"dc", 12}
		};
	}
}
