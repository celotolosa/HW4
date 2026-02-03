using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipeSpawnerPrefab;
    private float _timer = 0;
    private float _countTime = 3.3f;
    
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _countTime)
        {
            NextSpawn();
            _timer = 0f;
        }
        
    }

    private void NextSpawn()
    {
        float randY = Random.Range(-8.15f, -1.8f);
        Vector3 spawnPosition = new Vector3(3.54f, randY, 0);
        Instantiate(_pipeSpawnerPrefab, spawnPosition, Quaternion.identity);
    }
}
