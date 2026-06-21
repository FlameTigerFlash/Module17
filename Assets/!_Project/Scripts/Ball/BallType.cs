using UnityEngine;

public enum BallColor {None, Blue, Green, Red, Yellow, Purple};

public class BallType : MonoBehaviour
{
    [SerializeField] private BallColor _ballColor = BallColor.None;

    public virtual BallColor BallColor => _ballColor;

    public void Collect()
    {
        Destroy(gameObject);
    }
}
