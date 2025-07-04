using UnityEngine;

public class CoinManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int coins = PlayerPrefs.GetInt("Coins", 0);
            PlayerPrefs.SetInt("Coins", coins + 1);
            Destroy(gameObject);
        }
    }
}