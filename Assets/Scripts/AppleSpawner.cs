using UnityEngine;
using UnityEngine.InputSystem;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObj;
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
            interval *= 0.98f;
        }
    }

    void SpawnObject()
    {
        Instantiate(spawnObj, transform.position, transform.rotation);
    }
}
