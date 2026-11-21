using UnityEngine;

public class Ball : MonoBehaviour
{
[SerializeField] Vector2 startSpeed = Vector2.up;
Rigidbody2D rb2D;
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb2D.linearVelocity = startSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("BallKiller"))
        {
            Destroy(gameObject);
        }
    }
}
