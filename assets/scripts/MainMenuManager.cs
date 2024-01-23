using Godot;

public class MainMenuManager : Control
{
	[Export]
	PackedScene launchLevel;

	private void PlayPressed()
	{
		if (launchLevel != null)
		{
			var levelInstance = launchLevel.Instance();
			GetTree().Root.AddChild(levelInstance);
		}
	}

	private void QuitPressed()
	{
		GetTree().Quit();
	}

}
