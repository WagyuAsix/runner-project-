using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coinCount;

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
    }

    public void DecreaseCoinAmount(int amount)
    {
        if (coinCount > 0)
        {
           coinCount -= amount;
        }
        
    }



    // public void SetCoinCount(int newCoinCount)
    // {
    //     coinCount = newCoinCount;
    // }


}
