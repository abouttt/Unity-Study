using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum MouseEvent
    {
        Press,
        PointerDown,
        PointerUp,
        Click,
    }

    public enum Layer
    {
        Ground = 6,
        Obstacle,
        Monster,
        Interaction,
    }

    public enum ObjectTier
    {
        Normal,
        Rare,
        Legend,
    }
}