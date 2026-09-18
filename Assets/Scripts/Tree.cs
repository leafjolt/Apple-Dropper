using UnityEngine;

public class Tree : MonoBehaviour
{
    private float xSpeed = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            xSpeed = -xSpeed;
        }
        transform.position = new Vector2(transform.position.x + Time.deltaTime * xSpeed, transform.position.y);
        if (Mathf.Abs(xSpeed) < 15)
        {
            xSpeed *= 1.00005f;
        }
    }
}
