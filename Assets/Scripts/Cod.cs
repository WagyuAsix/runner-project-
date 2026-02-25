using Unity.VisualScripting;
using UnityEngine;

public class Cod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float horizontalSpeed;

    private float xLimit;
    private void Start()
    {
        xLimit = 10f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (transform.position.x > -xLimit)
            {
              transform.Translate(Vector3.left * forwardSpeed * Time.deltaTime);

            }
              


        }

        else if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (transform.position.x < xLimit) 
            {
                transform.Translate(Vector3.right * forwardSpeed * Time.deltaTime);


            }

           
        }



        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
    }

}
