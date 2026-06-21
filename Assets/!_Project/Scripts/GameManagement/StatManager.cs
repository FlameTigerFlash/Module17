using UnityEngine;
using UnityEngine.Events;

public class StatManager : MonoBehaviour
{
    [SerializeField] private ScoreDisplay _scoreDisplay;
    [SerializeField] private PenaltyDisplay _penaltyDisplay;

    public UnityEvent<int, int> StatsChangedEvent;

    public int Score
    {
        get
        {
            return _score;
        }
        protected set
        {
            _score = value;
            StatsChangedEvent.Invoke(_score, _penalty);
            _scoreDisplay.Display(value);
        }
    }

    public int Penalty
    {
        get
        {
            return _penalty;
        }
        protected set
        {
            _penalty = value;
            StatsChangedEvent.Invoke(_score, _penalty);
            _penaltyDisplay.Display(value);
        }
    }

    private int _score = 0;
    private int _penalty = 0;

    public void ResetScore()
    {
        Score = 0;
        Penalty = 0;
    }

    public void IncrementScore()
    {
        Score += 1;
    }

    public void IncrementPenalty()
    {
        Penalty += 1;
    }
}
