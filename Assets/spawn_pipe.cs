using UnityEngine;

public class spawn_pipe : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }

    }
    void spawnpipe()
    {
        float lowest = transform.position.y - height;
        float highest = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest),0), transform.rotation);
    }
}
