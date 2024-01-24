using Godot;

public class LevelSelectionManager : Control
{

<<<<<<< Updated upstream
    // Called when the node enters the scene tree for the first time.
    private void LaunchLevel(int index)
    {
        PackedScene game = ResourceLoader.Load("res://assets/scenes/levels/Game.tscn") as PackedScene;
        
        var levelInstance = game.Instance();
        levelInstance.Set("currentLevelIndex", index);
        GetTree().Root.AddChild(levelInstance);
        this.QueueFree();
    }
=======
	// Called when the node enters the scene tree for the first time.
	private void LaunchLevel(int index)
	{
		//PackedScene node = GetNode("res://assets/scripts/Game.gd");
		//node.Set("currentLevelIndex", index);

		//var levelInstance = node.Instance();
		//GetTree().Root.AddChild(levelInstance);
		//this.QueueFree();
	}
>>>>>>> Stashed changes
}
