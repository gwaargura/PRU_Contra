using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 moveDirection;
    public bool available;

    public void Start()
    {
        gameObject.SetActive(false);
    }
    public void Launch(Vector3 direction)
    {
        moveDirection = direction;
    }

    void Update()
    {
        if (available) return;
        transform.position += speed * Time.deltaTime * moveDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }
    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        available = true;
    }

    private void OnEnable()
    {
        available = false;
    }
}
