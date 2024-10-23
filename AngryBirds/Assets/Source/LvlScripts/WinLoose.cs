using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoose : MonoBehaviour
{
    [SerializeField] List<GameObject> _pigs = new List<GameObject>();
    [SerializeField] private float _timeBeforeCheck;

    private int _pigsDead = 0;
    public void Chek()
    {
        StartCoroutine(CheckAfterTime());
    }
    public void CountDeath()
    {
        _pigsDead++;

    }
    private IEnumerator CheckAfterTime()
    {
        yield return new WaitForSeconds(_timeBeforeCheck);
        if (_pigs.Count >= _pigsDead )
        {
            Debug.Log(_pigs.Count);
            Win();
        } else
        {
            Debug.Log(_pigs.Count);
            Loose();
        }
    }

    private void Win()
    {
        Debug.Log("a");
    }
    private void Loose()
    {
        Debug.Log("b");
    }
}
