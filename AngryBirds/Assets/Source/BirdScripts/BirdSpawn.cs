using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdScripts
{
    public class BirdSpawn : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private List<GameObject> _birdsPref = new List<GameObject>();
        private int _counter = 0;
        void Start()
        {

        }
        void Update()
        {

        }
        public void BirdRespawn()
        {
            _birdsPref[_counter].gameObject.transform.position = _spawnPoint.position;
            _counter++;
        }
    }
}
