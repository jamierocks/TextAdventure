﻿using TextAdventure.Domain;

namespace TextAdventure.Interface
{
    public interface IActionCoordinator
    {
        CommandOperationStatus Take(string objectName, string characterName, GameLocation location);
        CommandOperationStatus Drop(string objectName, string characterName, GameLocation location);
    }
}
