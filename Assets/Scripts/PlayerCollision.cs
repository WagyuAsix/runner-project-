using UnityEngine;
using UnityEngine.AI;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("coin"))
        {
           Coin coin = other.GetComponent<Coin>();

        
            Debug.Log(coin.GetValue());
        }

        else if (other.CompareTag("Obstacle"))
        {
         Obstacle obstacle = other.GetComponent<Obstacle>();
          Debug.Log(obstacle.GetCoinPenalty());


        }


    }//IM TWEAKING HHAHHAHAHAHAHAHA IM 




}
