using BirdScripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Level
{


    public class WinLoose : MonoBehaviour
    {
        [SerializeField] private GameObject _winScreen;
        [SerializeField] private GameObject _looseScreen;
        [SerializeField] private List<GameObject> _pigs = new List<GameObject>();
        [SerializeField] private float _timeBeforeCheck;
        [SerializeField] BirdSpawn _birdSpawn;
        private int _pigsDead = 0;
        public void Chek()
        {
            StartCoroutine(CheckAfterTime());
        }
        public void CountDeath()
        {
            _pigsDead++;
            if (_pigsDead >= _pigs.Count)
            {
                Win();
            }
        }
        private IEnumerator CheckAfterTime()
        {
            yield return new WaitForSeconds(_timeBeforeCheck);
            if (_pigsDead >= _pigs.Count)
            {

                Win();
            }
            else
            {

                Loose();
            }
        }

        private void Win()
        {
            _birdSpawn.CountBirdsLeft();
            _winScreen.SetActive(true);
        }
        private void Loose()
        {
            _looseScreen.SetActive(true);
        }
    }
}
