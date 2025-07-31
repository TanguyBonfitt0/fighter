using UnityEngine.InputSystem;
using UnityEngine;

public class BeginnerSystem : MonoBehaviour
{


    void Start()
    {
        InputSystem.settings.maxEventBytesPerUpdate = 0; 
    }
}

