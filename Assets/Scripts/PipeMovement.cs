using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float pipeMovementSpeed = 10.0f;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x - pipeMovementSpeed * Time.deltaTime, transform.position.y, transform.position.z);

        if (transform.position.x <= -15.0f)
        {
            Destroy(gameObject);
        }
    }
}
