using Godot;
using System;

public class ButtonRoll : Button
{
	[Export]
	private NodePath _valuePath;

	[Export]
	private NodePath _outputPath;

	private TextEdit _value;
	private Label _output;

	private RandomNumberGenerator rng = new RandomNumberGenerator();
	
	public override void _Ready()
	{
		rng.Randomize();
		_value = GetNode<Godot.TextEdit>(_valuePath);
		_output = GetNode<Godot.Label>(_outputPath);
	}

	private void Roll()
	{
		int roll = rng.RandiRange(1, 20);
		int adjustedRoll = roll + _value.Text.ToInt();
		_output.Text = adjustedRoll.ToString();

		GD.Print("Value: " + _value.Text);
		GD.Print("Roll: " + roll);
		GD.Print("Output: " + adjustedRoll);
		GD.Print("---");
	}
}
