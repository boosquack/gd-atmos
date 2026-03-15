using UnityEngine;

public class LeafCollectible : MonoBehaviour
{
    public int leafValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Leaf collected! +" + leafValue);

            // If you have a score manager later, add score here

            Destroy(gameObject);
        }
    }
}