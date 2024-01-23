using Godot;
using System;

public class PressurePlate : Area2D
{

	public override void _Ready()
	{
		Connect("body_entered", this, nameof(_OnBodyEntered));
		Connect("body_exited", this, nameof(_OnBodyExited));
	}
	
	[Signal]
	public delegate void PlayerActivated();
	
	[Signal]
	public delegate void PlayerLeft();

	private void _OnBodyEntered(Node body)
	{
		if (body.Name == "Player")
		{
			GetNode<Sprite>("normal").Visible = false;
			GetNode<Sprite>("activated").Visible = true;
			EmitSignal(nameof(PlayerActivated));
		}
	}

	private void _OnBodyExited(Node body)
	{
		if (body.Name == "Player")
		{
			GetNode<Sprite>("normal").Visible = true;
			GetNode<Sprite>("activated").Visible = false;
			EmitSignal(nameof(PlayerLeft));
		}
	}
}
