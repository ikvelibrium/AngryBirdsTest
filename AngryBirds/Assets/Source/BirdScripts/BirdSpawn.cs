using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdScripts
{
    public class BirdSpawn : MonoBehaviour
    {
        [SerializeField] WinLoose _winLoose;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private List<GameObject> _birdsPref = new List<GameObject>();
        private int _counter = 0;
        void Start()
        {

        }
        public void BirdRespawn()
        {
            _birdsPref[_counter].gameObject.transform.position = _spawnPoint.position;
            _counter++;
            if (_counter == _birdsPref.Count)
            {
                _winLoose.Chek();
            }
        }
    }
}
