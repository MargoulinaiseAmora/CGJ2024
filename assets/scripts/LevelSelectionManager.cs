using Godot;

public class LevelSelectionManager : Control
{
    [Export]
    PackedScene[] scenes;

    // Called when the node enters the scene tree for the first time.
    private void LaunchLevel(int index)
    {
        var levelInstance = scenes[index].Instance();
        GetTree().Root.AddChild(levelInstance);
        this.QueueFree();
    }
}
