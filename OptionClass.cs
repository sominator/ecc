using Godot;
using System;

public class OptionClass : OptionButton
{
	enum ClassChoices
	{
		Auromancer,
		NightAgent,
		Revolutionary,
		Technomancer,
		Terramancer,
		Vanguard
	}
	private void OnOptionClassItemSelected(int index)
	{
		string classChoice = ((ClassChoices)index).ToString();
		EmitSignal(nameof(ClassChosen), classChoice);
	}
	
	[Signal]
	private delegate void ClassChosen(string classChoice);
}
