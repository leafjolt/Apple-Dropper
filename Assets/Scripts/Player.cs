using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 mouse;
    public AudioClip soundEffect;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(soundEffect, 1.0f);
        }
    }
}
