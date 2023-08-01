using Godot;
using System;

public class CharacterManager : Node
{
	[Export]
	private NodePath _valStrengthPath;

	public override void _Ready()
	{
		//TextEdit valStrength = GetNode<Godot.TextEdit>(_valStrengthPath);
		//valStrength.Text = "1";

		TextEdit valueStrength = GetNode<Godot.TextEdit>("/root/Main/PanelAbilities/ValueStrength");		
		valueStrength.Text = "1";
	}

}
