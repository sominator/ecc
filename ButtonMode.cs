using Godot;
using System;

public class ButtonMode : CheckButton
{
	Panel panelInfo;
	Panel panelAbilities;
	Panel panelCombat;
	Panel panelArchetype;

	Theme lightTheme = (Theme)GD.Load("res://theme/sci-fi-theme-light.tres");
	Theme darkTheme = (Theme)GD.Load("res://theme/sci-fi-theme-dark.tres");

	public override void _Ready()
	{		
		panelInfo = GetNode<Godot.Panel>("/root/Main/PanelInfo");
		panelAbilities = GetNode<Godot.Panel>("/root/Main/PanelAbilities");
		panelCombat = GetNode<Godot.Panel>("/root/Main/PanelCombat");
		panelArchetype = GetNode<Godot.Panel>("/root/Main/PanelArchetype");
	}

	private void OnToggled(bool button_pressed)
	{
		if (button_pressed)
		{
			panelInfo.Theme = darkTheme;
			panelAbilities.Theme = darkTheme;
			panelCombat.Theme = darkTheme;
			panelArchetype.Theme = darkTheme;
		}
		else
		{
			panelInfo.Theme = lightTheme;
			panelAbilities.Theme = lightTheme;
			panelCombat.Theme = lightTheme;
			panelArchetype.Theme = lightTheme;
		}
	}

}
