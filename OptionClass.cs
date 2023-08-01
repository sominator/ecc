using Godot;
using System;

public class OptionClass : OptionButton
{
	enum ClassChoices
	{
		Auromancer,
		NIGHTAgent,
		Revolutionary,
		Technomancer,
		Terramancer,
		Vanguard
	}
	private void OnOptionClassItemSelected(int index)
	{
		ClassChoices classChoice = (ClassChoices)index;
		GD.Print(classChoice);
	}
}
