using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 mouse;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(mouse.x, transform.position.y);
    }

    void OnMouseMove(InputValue value)
    {
        mouse = value.Get<Vector2>();
        mouse = Camera.main.ScreenToWorldPoint(mouse);
    }
}
