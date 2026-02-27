using UnityEngine;
using UnityEngine.AI;

public class PlayerCollision : MonoBehaviour
{
    private CoinCounter coinCounter;

    private void Awake()
    {
        coinCounter = GetComponent<CoinCounter>();
    }
    private void OnTriggerEnter(Collider other)
    {

        Coin coin = null;
        if (other.TryGetComponent(out coin))
        {
           
            coinCounter.IncreaseCoinAmount(coin.GetValue());
            Debug.Log(coinCounter.GetCoinCount());
        }

        Obstacle obstacle;
        if (other.TryGetComponent(out obstacle)) ///
        {
        
          coinCounter.DecreaseCoinAmount(obstacle.GetCoinPenalty());
          
            Debug.Log(coinCounter.GetCoinCount());


        }


    }//IM TWEAKING HHAHHAHAHAHAHAHA!!!!! IM GOING INSANE!INSANITY!MINDLESSNESS!




}
