using Godot;
using System;

public class ButtonMode : CheckButton
{
	//store panels
	Panel panelInfo;
	Panel panelAbilities;
	Panel panelCombat;
	Panel panelArchetype;

	//store themes
	Theme lightTheme = (Theme)GD.Load("res://theme/sci-fi-theme-light.tres");
	Theme darkTheme = (Theme)GD.Load("res://theme/sci-fi-theme-dark.tres");

	public override void _Ready()
	{	
		//get panels based on directory path	
		panelInfo = GetNode<Godot.Panel>("/root/Main/PanelInfo");
		panelAbilities = GetNode<Godot.Panel>("/root/Main/PanelAbilities");
		panelCombat = GetNode<Godot.Panel>("/root/Main/PanelCombat");
		panelArchetype = GetNode<Godot.Panel>("/root/Main/PanelArchetype");
	}

	private void OnToggled(bool button_pressed)
	{
		if (button_pressed)
		{
			//toggle panels to dark mode
			panelInfo.Theme = darkTheme;
			panelAbilities.Theme = darkTheme;
			panelCombat.Theme = darkTheme;
			panelArchetype.Theme = darkTheme;
		}
		else
		{
			//toggle panels to light mode
			panelInfo.Theme = lightTheme;
			panelAbilities.Theme = lightTheme;
			panelCombat.Theme = lightTheme;
			panelArchetype.Theme = lightTheme;
		}
	}

}
