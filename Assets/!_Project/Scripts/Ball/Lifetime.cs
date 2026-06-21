using System.Collections;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    [SerializeField] private float _lifetime = 10f;

    private void Start()
    {
        StartCoroutine(DestroyAfterLifetime(_lifetime));
    }

    private IEnumerator DestroyAfterLifetime(float lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
