using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] TMP_Text _currentScore;
    private float _points;


    void Start()
    {
        _points = 0;
        Locator.Player.Point += HandlePlayerPass;
    }
    public void HandlePlayerPass()
    {
        Debug.Log("point added");
        _points++;
        _currentScore.text = _points.ToString();
    }
    
}
