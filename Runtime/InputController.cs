using UnityEngine;

public class InputController : MonoBehaviour
{
    private IInputHandler inputHandler;

    public delegate void InputDetected(Vector2 screenPosition);
    public static event InputDetected OnInput;

    private void Awake()
    {
#if UNITY_EDITOR
        inputHandler = new EditorInputHandler();
#else
        inputHandler = new MobileInputHandler();
#endif
    }

    private void Update()
    {
        if (inputHandler.TryGetInputPosition(out Vector2 screenPosition))
        {
            OnInput?.Invoke(screenPosition);
        }
    }
}
