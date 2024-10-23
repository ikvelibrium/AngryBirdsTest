using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int _score;
    private void Start()
    {
        ShowPoints();
    }
    public void AddPoints(int _pointsToAdd)
    {
        _score += _pointsToAdd;
        ShowPoints();
    }
    private void ShowPoints()
    {
        _text.text = "Score:" + _score;
    }
}
