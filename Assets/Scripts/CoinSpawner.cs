using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public static int CoinCount = 0;
    [SerializeField] public int CoinsSpawnLimit = 10;
    [SerializeField] private Vector2 BottomLeftBorder = new Vector2(-5, -5);
    [SerializeField] private Vector2 TopRightBorder = new Vector2(5, 5);

    private void Start()
    {
        for (int i = 0; i < CoinsSpawnLimit; i++)
            SpawnCoin();
    }

    public void SpawnCoin()
    {
        float x = Random.Range(BottomLeftBorder.x, TopRightBorder.x);
        float y = Random.Range(BottomLeftBorder.y, TopRightBorder.y);
        Vector2 spawnPosition = new Vector2(x, y);
        Instantiate(Coin, spawnPosition, Quaternion.identity);
        CoinTrigger CoinTr = Coin.GetComponent<CoinTrigger>();
        if (CoinTr != null )
        {
            CoinTr.Spawner = this;
        }
    }

    public void OnCoinCollected()
    {
        SpawnCoin();
    }
}
