using Godot;
using System;

public class OptionClass : OptionButton
{
	//store output labels
	Label strengthOutput;
	Label agilityOutput;
	Label willOutput;
	Label personalityOutput;
	Label athleticsOutput;
	Label awarenessOutput;
	Label discernmentOutput;
	Label dramaOutput;
	Label grapplingOutput;
	Label hackingOutput;
	Label healingOutput;
	Label knowledgeOutput;
	Label mancyOutput;
	Label natureOutput;
	Label negotiationOutput;
	Label stealthOutput;
	Label thieveryOutput;
	Label tumblingOutput;
	Label vehiclesOutput;
	Label initiativeOutput;
	Label meleeAttackOutput;
	Label meleeDamageOutput;
	Label rangedAttackOutput;
	Label rangedDamageOutput;
	Label spellAttackOutput;

	//simple enum to track Class option button values rather than passing them as indices
	enum ClassChoices
	{
		Auromancer,
		NightAgent,
		Revolutionary,
		Technomancer,
		Terramancer,
		Vanguard
	}

	public override void _Ready()
	{
		//get output labels based on directory path
		strengthOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelStrengthOutput");
		agilityOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelAgilityOutput");
		willOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelWillOutput");
		personalityOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelPersonalityOutput");
		athleticsOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelAthleticsOutput");
		awarenessOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelAwarenessOutput");
		discernmentOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelDiscernmentOutput");
		dramaOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelDramaOutput");
		grapplingOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelGrapplingOutput");
		hackingOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelHackingOutput");
		healingOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelHealingOutput");
		knowledgeOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelKnowledgeOutput");
		mancyOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelMancyOutput");
		natureOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelNatureOutput");
		negotiationOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelNegotiationOutput");
		stealthOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelStealthOutput");
		thieveryOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelThieveryOutput");
		tumblingOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelTumblingOutput");
		vehiclesOutput = GetNode<Godot.Label>("/root/Main/PanelAbilities/LabelVehiclesOutput");
		initiativeOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelInitiativeOutput");
		meleeAttackOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelMeleeAttackOutput");
		meleeDamageOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelMeleeDamageOutput");
		rangedAttackOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelRangedAttackOutput");
		rangedDamageOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelRangedDamageOutput");
		spellAttackOutput = GetNode<Godot.Label>("/root/Main/PanelCombat/LabelSpellAttackOutput");
	}

	//receive signal that Class option button selection has changed
	private void OnOptionClassItemSelected(int index)
	{
		//emit signal of the chosen class as a string
		string classChoice = ((ClassChoices)index).ToString();
		EmitSignal(nameof(ClassChosen), classChoice);
		ClearOutputs();
	}
	
	[Signal]
	private delegate void ClassChosen(string classChoice);

	//reset outputs to 0
	void ClearOutputs() 
	{
		strengthOutput.Text = "0";
		agilityOutput.Text = "0";
		willOutput.Text = "0";
		personalityOutput.Text = "0";
		athleticsOutput.Text = "0";
		awarenessOutput.Text = "0";
		discernmentOutput.Text = "0";
		dramaOutput.Text = "0";
		grapplingOutput.Text = "0";
		hackingOutput.Text = "0";
		healingOutput.Text = "0";
		knowledgeOutput.Text = "0";
		mancyOutput.Text = "0";
		natureOutput.Text = "0";
		negotiationOutput.Text = "0";
		stealthOutput.Text = "0";
		thieveryOutput.Text = "0";
		tumblingOutput.Text = "0";
		vehiclesOutput.Text = "0";
		initiativeOutput.Text = "0";
		meleeAttackOutput.Text = "0";
		meleeDamageOutput.Text = "0";
		rangedAttackOutput.Text = "0";
		rangedDamageOutput.Text = "0";
		spellAttackOutput.Text = "0";
	}

}
