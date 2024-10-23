using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistructObject : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private float _hp = 3;
    [SerializeField] private int _pointsCost;
    [SerializeField] Score _score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.relativeVelocity.magnitude > _hp)
        {
            _audioManager.Play("WoodDestroy");
            _score.AddPoints(_pointsCost);
            Destroy(gameObject);
        }
        else
        {
            _hp -= collision.relativeVelocity.magnitude;
        }
    }
}
