using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject topPipe;
    public GameObject bottomPipe;

    [Header("Spawn Variables")]
    [SerializeField] private float spawnDelay = 1f;
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private float gap = 14.5f;
    void Start()
    {
        //Invoke the Spawn method after a small delay and repeat it at a fixed rate
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnRate);
    }

    private void Spawn()
    {
        //Spawn the top and bottom pipes with a randomized gap in between
        float num = Random.Range(-1f, 2f);
        float bottomPipeY = transform.position.y + num;
        Vector3 bottomPipePosition = new(transform.position.x, bottomPipeY, transform.position.z);
        Vector3 topPipePosition = new(transform.position.x, bottomPipeY + gap, transform.position.z);

        Instantiate(bottomPipe, bottomPipePosition, transform.rotation);
        Instantiate(topPipe, topPipePosition, transform.rotation);
    }

}
