using Godot;
using System;

public class Spirit : KinematicBody2D
{
	[Export] public int Speed = 500;
//	[Export] public int JumpSpeed = -400;
//	[Export] public int Gravity = 0;

	Vector2 velocity = new Vector2();
	//bool jumping = false;

	public void getInput()
	{
		velocity.x = 0;
		velocity.y = 0;
		bool right = Input.IsActionPressed("ui_right");
		bool left = Input.IsActionPressed("ui_left");
		bool up = Input.IsActionPressed("ui_up");
		bool down = Input.IsActionPressed("ui_down");
		bool jump = Input.IsActionPressed("ui_select");

		if (right)
		{
			velocity.x += Speed;
		}
		if (left)
		{
			velocity.x -= Speed;
		}
		if (down)
		{
			velocity.y += Speed;
		}
		if (up || jump)
		{
			velocity.y -= Speed;
		}
	}

	public override void _PhysicsProcess(float delta)
	{
		getInput();
		velocity = MoveAndSlide(velocity, new Vector2(0, 0));
	}
}
