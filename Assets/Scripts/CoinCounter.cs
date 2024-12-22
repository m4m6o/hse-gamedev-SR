using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public Text CoinCounterText;

    private void Update()
    {
        CoinCounterText.text = "Coins: " + CoinSpawner.CoinCount;
    }
}
