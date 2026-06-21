using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void Display(int score)
    {
        _text.text = score.ToString();
    }
}
