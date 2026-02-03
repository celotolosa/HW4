using UnityEngine;

public class MovesLeft : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 0.3f;
    [SerializeField] private Transform _transform;
    private UI _ui;

    /*void Start()
    {
        Locator.Player.Point += HandlePlayerPass;
    }*/

    void Update()
    {
        _transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            HandlePlayerPass();
        }
    }

    public void HandlePlayerPass()
    {
        _ui.HandlePlayerPass();
    }*/
}
