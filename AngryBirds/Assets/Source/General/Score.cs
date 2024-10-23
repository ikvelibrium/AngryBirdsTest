using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private int _score;
    [SerializeField] private int _pointPerBirdLeft;
    [SerializeField] private int _scoreToGetOneStar;
    [SerializeField] private int _scoreToGetTwoStars;
    [SerializeField] private int _scoreToGetThreeStars;
    [SerializeField] private List<GameObject> _stars = new List<GameObject>();
    private int _birdsLeft;
    private void Start()
    {
        ShowPoints();
    }
    public void CountLeftBirds(int leftBirds)
    {
        AddPoints(leftBirds * _pointPerBirdLeft);
        CheckStars();
    }
    public void AddPoints(int _pointsToAdd)
    {
        _score += _pointsToAdd;
        ShowPoints();
    }
    public void CheckStars()
    {
        if (_score >= _scoreToGetOneStar && _score < _scoreToGetTwoStars)
        {
            _stars[0].gameObject.SetActive(true);
        } else if (_score >= _scoreToGetTwoStars && _score < _scoreToGetThreeStars)
        {
            _stars[0].gameObject.SetActive(true);
            _stars[1].gameObject.SetActive(true);
        } else if (_score >= _scoreToGetThreeStars)
        {
            _stars[0].gameObject.SetActive(true);
            _stars[1].gameObject.SetActive(true);
            _stars[2].gameObject.SetActive(true);
        }
    }
    private void ShowPoints()
    {
        _text.text = "Score:" + _score;
      
    }

}
