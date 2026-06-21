using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float _gameEndDelay = 1.5f;

    [SerializeField] private int _victoryScore = 3;
    [SerializeField] private int _defeatPenaltyAmount = 3;
    [SerializeField] private int _victoryGapThreshold = 2;
    [SerializeField] private int _defeatGapThreshold = 2;

    public UnityEvent LevelCompletedEvent;
    public UnityEvent LevelFailedEvent;

    public void CheckGameEndConditions(int score, int penalty)
    {
        if (penalty >= _defeatPenaltyAmount && penalty - score >= _defeatGapThreshold)
        {
            StartCoroutine(SetDefferred(SetDefeat, _gameEndDelay));
            return;
        }
        if (score >= _victoryScore && score - penalty >= _victoryGapThreshold)
        {
            StartCoroutine(SetDefferred(SetVictory, _gameEndDelay));
            return;
        }
    }

    public void SetVictory()
    {
        Debug.Log("Level completed!");
        LevelCompletedEvent.Invoke();
    }

    public void SetDefeat()
    {
        Debug.Log("Level failed!");
        LevelFailedEvent.Invoke();
    }

    private IEnumerator SetDefferred(Action action, float delay)
    {
        yield return new WaitForSeconds(delay);
        action.Invoke();
    }
}
