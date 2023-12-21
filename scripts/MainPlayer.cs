using Godot;
using System;

public partial class MainPlayer : Sprite2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("_Ready(): MainPlayer : Sprite2D");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        GD.Print($"_Process(): MainPlayer : Sprite2D ({delta})");
    }
}
