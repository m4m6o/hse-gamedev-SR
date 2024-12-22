using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    [SerializeField] public CoinSpawner Spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CoinSpawner.CoinCount++;
            Destroy(gameObject);
            Spawner.OnCoinCollected();
        }
    }
}
