using UnityEngine;

public interface IInputHandler
{
    bool TryGetInputPosition(out Vector2 screenPosition);
}