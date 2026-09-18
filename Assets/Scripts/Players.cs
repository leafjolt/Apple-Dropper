using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private GameObject player3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            if (player3 != null) {
                Destroy(player3);
            } else if (player2 != null) {
                Destroy(player2);
            } else {
                Destroy(player1);
                Time.timeScale = 0.0f;
            }
        }
    }
}
