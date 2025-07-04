using UnityEngine;

public class MobileInputHandler : IInputHandler
{
    public bool TryGetInputPosition(out Vector2 screenPosition)
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            screenPosition = Input.GetTouch(0).position;
            return true;
        }

        screenPosition = default;
        return false;
    }
}