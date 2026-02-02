using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] private float _jumpForce = 3.8f;
    
    public delegate void PointDelegate();
    public event PointDelegate Point;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Counter"))
        {
            Debug.Log("Add point to high score and current score, check if the current score > high score.");
            Pass();
        }
    }

    public void Pass()
    {
        Point?.Invoke();
    }
}
