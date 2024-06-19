using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public float pickupRadius = 10f;  
    public GameObject player;  
    private bool isCollected = false; 

    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickupRadius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.name == player.name && !isCollected)
            {
                    CollectKey(player);
            }
        }
    }

    void CollectKey(GameObject player)
    {
        isCollected = true;
        player.GetComponent<PlayerInventory>().hasKey = true; 
        gameObject.SetActive(false); 
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, pickupRadius);
    }
}
