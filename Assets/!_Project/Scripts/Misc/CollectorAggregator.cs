using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CollectorAggregator : MonoBehaviour
{
    [SerializeField] private List<BallCollector> _collectors;

    [SerializeField] private StatManager _statManager;

    private void Awake()
    {
        AssignEvents();
    }

    private void AssignEvents()
    {
        foreach (BallCollector collector in _collectors)
        {
            collector.AcceptedEvent.RemoveAllListeners();
            collector.DeniedEvent.RemoveAllListeners();

            collector.AcceptedEvent.AddListener(_statManager.IncrementScore);
            collector.DeniedEvent.AddListener(_statManager.IncrementPenalty);
        }
    }
}
