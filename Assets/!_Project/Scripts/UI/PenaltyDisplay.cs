using TMPro;
using UnityEngine;

public class PenaltyDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void Display(int penalty)
    {
        _text.text = penalty.ToString();
    }
}
