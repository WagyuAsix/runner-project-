using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Obstacle : MonoBehaviour, ICollidable
{
    [SerializeField] private int coinPenalty;

    public void OnCollideWithPlayer(PlayerCollision playerCollision)
    {
        CoinCounter coinCounter;
        if (playerCollision.TryGetComponent(out coinCounter))
        {
            coinCounter.DecreaseCoinAmount(coinPenalty);
            
            Debug.Log(coinCounter.GetCoinCount());
        }
    }
}