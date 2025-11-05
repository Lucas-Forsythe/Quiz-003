using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player hit a spike! Restarting level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

