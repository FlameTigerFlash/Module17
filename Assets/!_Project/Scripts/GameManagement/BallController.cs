using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float _pushForce = 5f;

    public GameObject CurrentBall => _currentBall;

    private GameObject _currentBall;
    private Rigidbody _currentBallRB;

    public void SetCurrentBall(GameObject ball)
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Selected ball does not have a rigid body.");
            return;
        }

        _currentBall = ball;
        _currentBallRB = rb;
    }

    public void PushRight()
    {
        if (_currentBall == null)
        {
            return;
        }

        _currentBallRB.AddForce(Vector3.right * _pushForce, ForceMode.Impulse);
    }

    public void PushLeft()
    {
        if (_currentBall == null)
        {
            return;
        }

        _currentBallRB.AddForce(Vector3.left * _pushForce, ForceMode.Impulse);
    }
}
