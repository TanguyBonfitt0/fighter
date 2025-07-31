using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSelector : MonoBehaviour
{
    public void ChoisirClavier()
    {
        PlayerPrefs.SetString("controlType", "keyboard");
        SceneManager.LoadScene("Arena");
    }

    public void ChoisirManette()
    {
        PlayerPrefs.SetString("controlType", "gamepad");
        SceneManager.LoadScene("Arena");
    }
}