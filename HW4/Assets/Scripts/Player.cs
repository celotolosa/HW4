using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] private float _jumpForce = 3.8f;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _jumpClip;
    [SerializeField] private AudioClip _deathClip;
    
    public delegate void PointDelegate();
    public event PointDelegate Point;

    public delegate void PlayerDiedDelegate();
    public event PlayerDiedDelegate Died;

    private bool _inputEnabled = true;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (!_inputEnabled) return;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);

        _audioSource.PlayOneShot(_jumpClip);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Counter"))
        {
            Debug.Log("Add point to high score and current score, check if the current score > high score.");
            Point?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Pipe"))
        {
            Die();
            _audioSource.PlayOneShot(_deathClip);
        }
    }

    private void Die()
    {
        if (!_inputEnabled) return;

        _inputEnabled = false;
        _rb.velocity = Vector2.zero;
        _rb.simulated = false;

        Died?.Invoke();
    }

    public void ResetPlayer()
    {
        _inputEnabled = true;
        _rb.simulated = true;
        _rb.velocity = Vector2.zero;
    }

    
}
