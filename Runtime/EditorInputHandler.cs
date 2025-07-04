using UnityEngine;

public class EditorInputHandler : IInputHandler
{
    public bool TryGetInputPosition(out Vector2 screenPosition)
    {
        if (Input.GetMouseButtonDown(0))
        {
            screenPosition = Input.mousePosition;
            return true;
        }

        screenPosition = default;
        return false;
    }
}