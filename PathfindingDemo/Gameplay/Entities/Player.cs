﻿using PathfindingDemo.Gameplay.Enviroment;
using PathfindingDemo.Gameplay.Util;

namespace PathfindingDemo.Gameplay.Entities;
internal class Player : Entity
{
    public Player(World _world) : base(_world, new Position(4, 4))
    {
        Color = ConsoleColor.Green;
    }

    protected override void Update()
    {
        if (Input.GetKeyDown(ConsoleKey.W))
            Move(Position.Down);

        if (Input.GetKeyDown(ConsoleKey.A))
            Move(Position.Left);

        if (Input.GetKeyDown(ConsoleKey.S))
            Move(Position.Up);

        if (Input.GetKeyDown(ConsoleKey.D))
            Move(Position.Right);
    }
}
