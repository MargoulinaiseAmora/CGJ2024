using Godot;
using System;

public class SettingsManager : Node
{
	public void ChangeFramerate(int framerate)
	{
		Engine.TargetFps = framerate;
	}
}
