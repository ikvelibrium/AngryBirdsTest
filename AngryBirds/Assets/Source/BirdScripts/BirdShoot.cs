using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Core;

namespace BirdScripts
{
    public class BirdShoot : MonoBehaviour
    {
        public Rigidbody2D SlingRb;

        [SerializeField] private BirdSpawn _birdSpawn;
        [SerializeField] private DrawSling _drawSling;
        [SerializeField] private AudioManager _audioManager;
        [SerializeField] private int _maxDistanceToPool = 3;
        private Rigidbody2D _rb;
        private bool _isPressed = false;
       
        private void Start()
        {
            _rb = gameObject.GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            if (_isPressed)
            {
                
                Vector2 _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                _drawSling.Draw(_rb.position);
                if (Vector2.Distance(_mousePosition, SlingRb.position) > _maxDistanceToPool)
                {
                    _rb.position = SlingRb.position + (_mousePosition - SlingRb.position).normalized * _maxDistanceToPool;
                }
                else
                {
                    _rb.position = _mousePosition;
                }
            }
        }
        public void BirdPressed(bool isPressed)
        {
            _isPressed = isPressed;
            _rb.isKinematic = isPressed;
        }

        public void BirdUnleashed(bool isPressed)
        {
            _isPressed = isPressed;
            _rb.isKinematic = isPressed;
            _audioManager.Play("BirdFly");
            _drawSling.DrawStartSling();
            StartCoroutine(Shoot());
        }

        IEnumerator Shoot()
        {
            yield return new WaitForSeconds(0.1f);

            gameObject.GetComponent<SpringJoint2D>().enabled = false;
            this.enabled = false;

            yield return new WaitForSeconds(1);
            _birdSpawn.BirdRespawn();
        }
    }
}
