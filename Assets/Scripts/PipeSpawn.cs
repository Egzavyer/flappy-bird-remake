using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;
    public GameObject pointLine;

    [Header("Spawn Variables")]
    [SerializeField] private float spawnDelay = 2f;
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float gap = 14.5f;
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnRate);
    }

    private void Spawn()
    {
        float num = Random.Range(-1f, 2f);
        float bottomPipeY = transform.position.y + num;
        Vector3 bottomPipePosition = new(transform.position.x, bottomPipeY, transform.position.z);
        Vector3 topPipePosition = new(transform.position.x, bottomPipeY + gap, transform.position.z);
        Vector3 pointLinePosition = new(transform.position.x + 4, transform.position.y, transform.position.z);

        Instantiate(bottomPipe, bottomPipePosition, transform.rotation);
        Instantiate(topPipe, topPipePosition, transform.rotation);
        Instantiate(pointLine, pointLinePosition, transform.rotation);
    }

}
