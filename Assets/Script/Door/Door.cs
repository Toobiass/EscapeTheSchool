using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject player;
    public WinScreenManager winScreenManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == player.name)
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();
            if (playerInventory != null && playerInventory.hasKey)
            {
                Debug.Log("You won!");
                if(winScreenManager == null)
                {
                    Debug.LogError("WinScreenManager not set.");
                    return;
                }
                winScreenManager.ShowWinScreen();
            }
            else
            {
                Debug.Log("You need the key to open the door.");
            }
        }
    }
}
