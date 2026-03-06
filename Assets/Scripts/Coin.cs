using System;
using UnityEngine;

public class Coin : MonoBehaviour, ICollidable
{
   [SerializeField] private int value;
    public void OnCollideWithPlayer(PlayerCollision playerCollision)
    {   

      CoinCounter coinCounter;
      if (playerCollision.TryGetComponent(out coinCounter))
      {
            coinCounter.IncreaseCoinAmount(value);
            
            Debug.Log(coinCounter.GetCoinCount());
      }

        Destroy(gameObject);
    }
}