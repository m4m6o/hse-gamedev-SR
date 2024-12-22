using UnityEngine;

public class GameReset : MonoBehaviour
{
    public Transform Player;
    [SerializeField] public Vector2 RespawnPosition = new Vector2(0f, -2.8f);
    [SerializeField] public float KillZone = -5f;

    private void Update()
    {
        if (Player.position.y < KillZone)
            ResetGame();
    }

    public void ResetGame()
    {
        CoinSpawner.CoinCount = 0;
        Player.position = RespawnPosition;
    }
}
