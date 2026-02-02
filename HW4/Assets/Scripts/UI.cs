using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] TMP_Text _currentScore;
    [SerializeField] TMP_Text _highScore;


    void Start()
    {
        Locator.Player.Point += HandlePlayerPass;
    }
    public void HandlePlayerPass()
    {
        _currentScore.text = _highScore.text;
    }

    
    void Update()
    {
        HandlePlayerPass();
    }
    
}
