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
        ICollidable collidable;

        if (other.TryGetComponent(out collidable))
        {
            collidable.OnCollideWithPlayer(this);
        }
    }

}
