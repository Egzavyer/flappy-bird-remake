using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float pipeMovementSpeed = 10.0f;

    private void Update()
    {
        //Move the pipe towards the left of the screen
        transform.position = new Vector3(transform.position.x - pipeMovementSpeed * Time.deltaTime, transform.position.y, transform.position.z);

        //Destroy the pipe if it goes off the screen
        if (transform.position.x <= -15.0f)
        {
            Destroy(gameObject);
        }
    }
}
