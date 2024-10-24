using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BirdScripts;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private BirdShoot _bird;

        void Update()
        {

        }

        private void OnMouseDown()
        {
            _bird.BirdPressed(true);
        }


        private void OnMouseUp()
        {
            _bird.BirdUnleashed(false);
        }
    }
}
