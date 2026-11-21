using UnityEngine;
using UnityEngine.InputSystem;

public class Paddle : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Rigidbody2D rb2D;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            rb2D.linearVelocityX = -speed;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            rb2D.linearVelocityX = speed;
        }
        else
        {
            rb2D.linearVelocityX = 0f;
        }
    }
}
