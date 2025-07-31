using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

[RequireComponent(typeof(PlayerInput))]
public class InputInitializer : MonoBehaviour
{
    private void Start()
    {
        var input = GetComponent<PlayerInput>();

        string controlType = PlayerPrefs.GetString("controlType", "keyboard");

        if (controlType == "gamepad" && Gamepad.current != null)
        {
            input.SwitchCurrentControlScheme("Gamepad", Gamepad.current);
        }
        else if (controlType == "keyboard")
        {
            input.SwitchCurrentControlScheme("Keyboard", Keyboard.current);
        }
    }
}