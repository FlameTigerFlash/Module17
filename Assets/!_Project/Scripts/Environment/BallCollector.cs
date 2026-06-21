using UnityEngine;
using UnityEngine.Events;

public class BallCollector : MonoBehaviour
{
    [SerializeField] private BallColor _acceptedColor = BallColor.None;

    public UnityEvent AcceptedEvent;
    public UnityEvent DeniedEvent;

    private void OnTriggerEnter(Collider other)
    {
        BallType ballType = other.GetComponent<BallType>();
        if (ballType == null)
        {
            return;
        }

        if (ballType.BallColor == _acceptedColor)
        {
            AcceptedEvent.Invoke();
        }
        else
        {
            DeniedEvent.Invoke();
        }

        ballType.Collect();
    }
}
