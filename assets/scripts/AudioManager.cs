using Godot;
using System;

public class testSon : Node
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{	
		NewGame();
	}
	
	public void NewGame()
	{
		AudioStreamPlayer Music = GetNode<AudioStreamPlayer>("Music");
		Music.Play();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
