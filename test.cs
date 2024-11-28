using Godot;
using System;
using System.Collections.Generic;

public partial class test : GridMap
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//get and store every filled cell to then sort
		//remember pos z = left, neg z = right, pos x = front, neg x = back
		//x coord -2 to 1 and z coord 0 to -1 are invalid (the space between the grids)
        var filledCells = GetUsedCells();
		List<Vector3I> leftFilledCells = new List<Vector3I>();
		List<Vector3I> rightFilledCells = new List<Vector3I>();
        GD.Print(filledCells);
		//sort filled cells into left and right
		foreach (var cell in filledCells)
		{
			if (cell.Z > 0 & !(cell.Z > 4))
				leftFilledCells.Add(cell);
			else if (cell.Z < -1 & !(cell.Z < -5))
				rightFilledCells.Add(cell);
			else continue;

		}
		GD.Print("Right:");
		foreach (var cell in rightFilledCells) { GD.Print(cell); }
		GD.Print("Left:");
		foreach (var cell in leftFilledCells) { GD.Print(cell); }
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        
    }
}
