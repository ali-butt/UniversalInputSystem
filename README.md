# Universal Input System for Unity 🎮🖱️📱

A lightweight, scalable input system for Unity that supports both **mouse** and **touch input** using clean architecture and interface-driven design. Ideal for prototyping, production projects, or educational use.

---

## 📦 Features

- Abstracts input using an interface (`IInputHandler`)
- Supports:
  - Mouse input in Editor
  - Touch input on Mobile
- Platform detection via `#if UNITY_EDITOR`
- Event-driven structure via a named delegate
- Easy to integrate into any project (2D or 3D)

---

## 🧱 Structure

InputController.cs → Core manager (event emitter)
EditorInputHandler.cs → Mouse input (Editor)
MobileInputHandler.cs → Touch input (Mobile)
IInputHandler.cs → Interface for extensibility

---

## 🛠️ How to Use

### 1. Import the scripts

You can copy-paste the `Runtime/` folder into your Unity project's `Assets/` directory.

### 2. Subscribe to input

```csharp
using UnityEngine;

public class MyListener : MonoBehaviour
{
    private void OnEnable() => InputController.OnInput += HandleInput;
    private void OnDisable() => InputController.OnInput -= HandleInput;

    private void HandleInput(Vector2 screenPos)
    {
        Debug.Log("Input at: " + screenPos);
        // You can convert to world position if needed
        // Vector3 world = Camera.main.ScreenToWorldPoint(screenPos);
    }
}

### 3. Add InputController to the scene
To activate the input system:

Create an empty GameObject (e.g., InputSystem)

Attach the InputController script to it

Press Play — it will start emitting input events

💡 You only need one instance of InputController in the scene.


## 📦 Dependencies
None. This system uses Unity's classic Input Manager, so no additional packages are required.

🔁 If you'd like a version for the New Input System, let us know or contribute via pull request.