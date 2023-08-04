using Godot;
using System;

public class ButtonRollEx : Button
{
	//store the node paths of stat values and outputs by exposing them in the inspector
	[Export]
	private NodePath _numberPath;

	[Export]
	private NodePath _typePath;

	[Export]
	private NodePath _modPath;

	[Export]
	private NodePath _outputPath;

	private TextEdit _number;
	private TextEdit _type;
	private TextEdit _mod;
	private Label _output;

	//store new RNG
	private RandomNumberGenerator rng = new RandomNumberGenerator();
	
	public override void _Ready()
	{
		//seed RNG
		rng.Randomize();
		_number = GetNode<Godot.TextEdit>(_numberPath);
		_type = GetNode<Godot.TextEdit>(_typePath);
		_mod = GetNode<Godot.TextEdit>(_modPath);
		_output = GetNode<Godot.Label>(_outputPath);
	}

	//roll dice, feed to output label and print to console
	private void RollEx()
	{
		int num = _number.Text.ToInt();
		int type = _type.Text.ToInt();
		int mod = _mod.Text.ToInt();

		int roll = 0;

		for (int i = 0; i < num; i++)
		{
			roll += rng.RandiRange(1, type);
			GD.Print("Rolling... " + roll);
		}

		int adjustedRoll = roll + mod;
		_output.Text = adjustedRoll.ToString();

		GD.Print("Number: " + num);
		GD.Print("Type: " + type);
		GD.Print("Roll: " + roll);
		GD.Print("Mod: " + mod);
		GD.Print("Output: " + adjustedRoll);
		GD.Print("---");
	}
}
