using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Level;
using Core;
namespace BirdScripts
{
    public class BirdSpawn : MonoBehaviour
    {
        [SerializeField] WinLoose _winLoose;
        [SerializeField] Score _score;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private List<GameObject> _birdsPref = new List<GameObject>();
        private int _counter = 0;

      
        public void CountBirdsLeft()
        {
            _score.CountLeftBirds(_birdsPref.Count - _counter);
        }
        public void BirdRespawn()
        {
            if (_counter >= _birdsPref.Count)
            {
                _winLoose.Chek();
            }
            _birdsPref[_counter].gameObject.transform.position = _spawnPoint.position;
            _counter++;
            
        }
    }
}
