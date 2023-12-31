using ECC;
using Godot;
using System;
using System.Collections.Generic;

public class CharacterManager : Node
{
	//new dictionary to store data based on selected class
	Dictionary<string, int> selectedClassData;

	//store stat text edits
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
	SpinBox valueHP;
	SpinBox valueCeridium;
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

	OptionButton optionArchetype;

	public override void _Ready()
	{
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
		//get stat values based on directory path
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
		valueHP = GetNode<Godot.SpinBox>("/root/Main/PanelCombat/SpinBoxHP");
		valueCeridium = GetNode<Godot.SpinBox>("/root/Main/PanelCombat/SpinBoxCeridium");
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

		//get archetype option button
		optionArchetype = GetNode<Godot.OptionButton>("/root/Main/PanelArchetype/OptionArchetype");
	}

	void UpdateSelectedClass(string classChoice)
	{
		//update class data and archetypes based on option button selection
		switch (classChoice)
		{
			case "Auromancer":
				selectedClassData = CharacterData.AuromancerData;
				optionArchetype.SetItemText(0, "Bladesinger");
				optionArchetype.SetItemText(1, "Siren");
				break;
			case "NightAgent":
				selectedClassData = CharacterData.NightAgentData;
				optionArchetype.SetItemText(0, "Nightpath");
				optionArchetype.SetItemText(1, "Daypath");
				break;
			case "Revolutionary":
				selectedClassData = CharacterData.RevolutionaryData;
				optionArchetype.SetItemText(0, "Gunslinger");
				optionArchetype.SetItemText(1, "Sharpshooter");
				break;
			case "Technomancer":
				selectedClassData = CharacterData.TechnomancerData;
				optionArchetype.SetItemText(0, "Combat Engineer");
				optionArchetype.SetItemText(1, "Net Specialist");
				break;
			case "Terramancer":
				selectedClassData = CharacterData.TerramancerData;
				optionArchetype.SetItemText(0, "Arcane Pitcher");
				optionArchetype.SetItemText(1, "Nature's Harbinger");
				break;
			case "Vanguard":
				selectedClassData = CharacterData.VanguardData;
				optionArchetype.SetItemText(0, "Assassin");
				optionArchetype.SetItemText(1, "Shadowstalker");
				break;
			default:
				selectedClassData = CharacterData.AuromancerData;
				optionArchetype.SetItemText(0, "Bladesinger");
				optionArchetype.SetItemText(1, "Siren");
				break;
		}
	}

	//update text edit values based on currently selected class data
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
		valueHP.Value = selectedClassData["hp"];
		valueCeridium.Value = selectedClassData["ceridium"];
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
