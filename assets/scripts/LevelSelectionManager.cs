using Godot;

public class LevelSelectionManager : Control
{

    // Called when the node enters the scene tree for the first time.
    private void LaunchLevel(int index)
    {
        PackedScene game = ResourceLoader.Load("res://assets/scenes/levels/Game.tscn") as PackedScene;
        
        var levelInstance = game.Instance();
        levelInstance.Set("currentLevelIndex", index);
        GetTree().Root.AddChild(levelInstance);
        this.QueueFree();
    }
}
