using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdScripts
{
    public class BirdDie : MonoBehaviour
    {
        [SerializeField] private float _secondsToDieAfterCollision = 3;
        [SerializeField] private AudioManager _audioManager;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 8)
            {
                StartCoroutine(Die());
            }
           
        }
        IEnumerator Die()
        {
            yield return new WaitForSeconds(_secondsToDieAfterCollision);
            _audioManager.Play("BirdDie");
            Destroy(gameObject);
        }
    }
}
 