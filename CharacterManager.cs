using ECC;
using Godot;
using System;
using System.Collections.Generic;

public class CharacterManager : Node
{
	//[Export]
	//private NodePath _valStrengthPath;

	Dictionary<string, int> selectedClassData;

	TextEdit valueStrength;
	TextEdit valueAgility;
	TextEdit valueWill;
	TextEdit valuePersonality;
	TextEdit valueAthletics;
	TextEdit valueAwareness;
	TextEdit valueDiscernment;
	TextEdit valueDrama;
	TextEdit valueGrappling;
	TextEdit valueHacking;
	TextEdit valueHealing;
	TextEdit valueKnowledge;
	TextEdit valueMancy;
	TextEdit valueNature;
	TextEdit valueNegotiation;
	TextEdit valueStealth;
	TextEdit valueThievery;
	TextEdit valueTumbling;
	TextEdit valueVehicles;
	TextEdit valueHP;
	TextEdit valueCeridium;
	TextEdit valueAC;
	TextEdit valueDC;
	TextEdit valueInitiative;
	TextEdit valueMeleeAttack;
	TextEdit valueMeleeDamageNumber;
	TextEdit valueMeleeDamageType;
	TextEdit valueMeleeDamageMod;
	TextEdit valueRangedAttack;
	TextEdit valueRangedDamageNumber;
	TextEdit valueRangedDamageType;
	TextEdit valueRangedDamageMod;
	TextEdit valueSpellAttack;

	public override void _Ready()
	{
		//TextEdit valStrength = GetNode<Godot.TextEdit>(_valStrengthPath);
		//valStrength.Text = "1";

		GetNodes();
		UpdateSelectedClass("Auromancer");
		UpdateClassData();
	}
	
	private void OnClassChosen(string classChoice)
	{
		UpdateSelectedClass(classChoice);
		UpdateClassData();
	}
	
	void GetNodes()
	{
		valueStrength = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueStrength");
		valueAgility = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueAgility");
		valueWill = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueWill");
		valuePersonality = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValuePersonality");
		valueAthletics = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueAthletics");
		valueAwareness = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueAwareness");
		valueDiscernment = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueDiscernment");
		valueDrama = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueDrama");
		valueGrappling = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueGrappling");
		valueHacking = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueHacking");
		valueHealing = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueHealing");
		valueKnowledge = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueKnowledge");
		valueMancy = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueMancy");
		valueNature = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueNature");
		valueNegotiation = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueNegotiation");
		valueStealth = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueStealth");
		valueThievery = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueThievery");
		valueTumbling = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueTumbling");
		valueVehicles = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueVehicles");
		valueHP = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueHP");
		valueCeridium = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueCeridium");
		valueAC = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueAC");
		valueDC = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueDC");
		valueInitiative = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueInitiative");
		valueMeleeAttack = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueMeleeAttack");
		valueMeleeDamageNumber = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueMeleeDamageNumber");
		valueMeleeDamageType = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueMeleeDamageType");
		valueMeleeDamageMod = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueMeleeDamageMod");
		valueRangedAttack = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueRangedAttack");
		valueRangedDamageNumber = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueRangedDamageNumber");
		valueRangedDamageType = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueRangedDamageType");
		valueRangedDamageMod = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueRangedDamageMod");
		valueSpellAttack = GetNode<Godot.TextEdit>("/root/Main/PanelCombat/ValueSpellAttack");
	}

	void UpdateSelectedClass(string classChoice)
	{
		switch (classChoice)
		{
			case "Auromancer":
				selectedClassData = CharacterData.AuromancerData;
				break;
			case "NightAgent":
				selectedClassData = CharacterData.NightAgentData;
				break;
			case "Revolutionary":
				selectedClassData = CharacterData.RevolutionaryData;
				break;
			case "Technomancer":
				selectedClassData = CharacterData.TechnomancerData;
				break;
			case "Terramancer":
				selectedClassData = CharacterData.TerramancerData;
				break;
			case "Vanguard":
				selectedClassData = CharacterData.VanguardData;
				break;
			default:
				selectedClassData = CharacterData.AuromancerData;
				break;
		}
	}
	void UpdateClassData()
	{
		valueStrength.Text = selectedClassData["strength"].ToString();
		valueAgility.Text = selectedClassData["agility"].ToString();
		valueWill.Text = selectedClassData["will"].ToString();
		valuePersonality.Text = selectedClassData["personality"].ToString();
		valueAthletics.Text = selectedClassData["athletics"].ToString();
		valueAwareness.Text = selectedClassData["awareness"].ToString();
		valueDiscernment.Text = selectedClassData["discernment"].ToString();
		valueDrama.Text = selectedClassData["drama"].ToString();
		valueGrappling.Text = selectedClassData["grappling"].ToString();
		valueHacking.Text = selectedClassData["hacking"].ToString();
		valueHealing.Text = selectedClassData["healing"].ToString();
		valueKnowledge.Text = selectedClassData["knowledge"].ToString();
		valueMancy.Text = selectedClassData["mancy"].ToString();
		valueNature.Text = selectedClassData["nature"].ToString();
		valueNegotiation.Text = selectedClassData["negotiation"].ToString();
		valueStealth.Text = selectedClassData["stealth"].ToString();
		valueThievery.Text = selectedClassData["thievery"].ToString();
		valueTumbling.Text = selectedClassData["tumbling"].ToString();
		valueVehicles.Text = selectedClassData["vehicles"].ToString();
		valueHP.Text = selectedClassData["hp"].ToString();
		valueCeridium.Text = selectedClassData["ceridium"].ToString();
		valueAC.Text = selectedClassData["ac"].ToString();
		valueDC.Text = selectedClassData["dc"].ToString();
		valueInitiative.Text = selectedClassData["initiative"].ToString();
		valueMeleeAttack.Text = selectedClassData["meleeAttack"].ToString();
		valueMeleeDamageNumber.Text = selectedClassData["meleeDamageNumber"].ToString();
		valueMeleeDamageType.Text = selectedClassData["meleeDamageType"].ToString();
		valueMeleeDamageMod.Text = selectedClassData["meleeDamageMod"].ToString();
		valueRangedAttack.Text = selectedClassData["rangedAttack"].ToString();
		valueRangedDamageNumber.Text = selectedClassData["rangedDamageNumber"].ToString();
		valueRangedDamageType.Text = selectedClassData["rangedDamageType"].ToString();
		valueRangedDamageMod.Text = selectedClassData["rangedDamageMod"].ToString();
		valueSpellAttack.Text = selectedClassData["spellAttack"].ToString();
	}
}
