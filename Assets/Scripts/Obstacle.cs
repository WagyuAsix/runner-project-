using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int CoinPenalty;
    public int coinPenalty;

    public int GetCoinPenalty()
    {
        return coinPenalty;
    }
}