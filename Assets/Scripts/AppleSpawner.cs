using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObj;
    private float maxInterval = 1.0f;
    private float interval = 1.0f;
    private float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            SpawnObject();
            timer = 0f;
            if (maxInterval > 0.5f)
            {
                maxInterval *= 0.98f;
            }
            interval = Random.Range(0.0f, maxInterval);
        }
    }

    void SpawnObject()
    {
        Instantiate(spawnObj, transform.position, transform.rotation);
    }
}
