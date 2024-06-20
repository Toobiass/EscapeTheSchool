using UnityEngine;
using UnityEngine.UI;

public class WinScreenManager : MonoBehaviour
{
    public GameObject winScreen;

    void Start()
    {
        winScreen.SetActive(false); // Start with the win screen hidden
    }

    public void ShowWinScreen()
    {
        winScreen.SetActive(true); // Show the win screen
    }
}
