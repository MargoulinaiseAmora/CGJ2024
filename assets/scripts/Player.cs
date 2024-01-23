using Godot;
using System;

public class Player : KinematicBody2D
{
	[Export] public int RunSpeed = 100;
	[Export] public int JumpSpeed = -400;
	[Export] public int Gravity = 1200;

	Vector2 velocity = new Vector2();
	bool jumping = false;

	public void getInput()
	{
		velocity.x = 0;
		bool right = Input.IsActionPressed("ui_right");
		bool left = Input.IsActionPressed("ui_left");
		bool jump = Input.IsActionPressed("ui_select");

		if (jump && IsOnFloor())
		{
			jumping = true;
			velocity.y = JumpSpeed;
		}
		if (right)
		{
			velocity.x += RunSpeed;
		}
		if (left)
		{
			velocity.x -= RunSpeed;
		}
	}

	public override void _PhysicsProcess(float delta)
	{
		getInput();
		velocity.y += Gravity * delta;
		if (jumping && IsOnFloor())
		{
			jumping = false;
		}
		velocity = MoveAndSlide(velocity, new Vector2(0, -1));
	}
}
