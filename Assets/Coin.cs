using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
       {
            Debug.Log($"Player collected {coinValue} coin(s)!");



            Destroy(gameObject);
        }
    }
}

