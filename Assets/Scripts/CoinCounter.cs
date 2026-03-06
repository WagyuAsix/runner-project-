using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coinCount;
    [SerializeField] private TextMeshProUGUI coinCountText;

    private void Awake()
    {
        coinCount = 0;
    }

    public int GetCoinCount()
    { 
        return coinCount;
    }

    public void IncreaseCoinAmount(int amount)
    {
        coinCount += amount;

        RefreshCoinCountText();
    }

    public void DecreaseCoinAmount(int amount)
    {
        if (coinCount > 0)
        {
           coinCount -= amount;
        }

        RefreshCoinCountText();
    }

    private void RefreshCoinCountText()
    {
        coinCountText.text = "SOULS REAPED: " + coinCount;
    }


    // public void SetCoinCount(int newCoinCount)
    // {
    //     coinCount = newCoinCount;
    // }


}
