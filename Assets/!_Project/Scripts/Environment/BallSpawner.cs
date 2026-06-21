using UnityEngine;
using System.Collections.Generic;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _balls;

    [SerializeField] private BallController _ballController;

    [SerializeField] private Transform _spawnPoint;

    public void TrySpawnRandomBall()
    {
        if (!(_ballController.CurrentBall == null))
        {
            return;
        }

        int randomInd = Random.Range(0, _balls.Count);

        GameObject ball = Instantiate(_balls[randomInd], _spawnPoint.position, Quaternion.identity);

        _ballController.SetCurrentBall(ball);
    }
}
