using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

namespace Level
{
    public class Pig : MonoBehaviour
    {
        [SerializeField] private AudioManager _audioManager;
        [SerializeField] private float _hp = 3;
        [SerializeField] private int _pointsCost;
        [SerializeField] WinLoose _winLoose;
        [SerializeField] Score _score;

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.relativeVelocity.magnitude > _hp)
            {
                _score.AddPoints(_pointsCost);
                _winLoose.CountDeath();
                _audioManager.Play("PigDie");
                Destroy(gameObject);
            }
            else
            {
                _hp -= collision.relativeVelocity.magnitude;
            }
        }
    }
}
