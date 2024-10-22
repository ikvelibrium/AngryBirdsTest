using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pig : MonoBehaviour
{
    [SerializeField] private float _velocityToDie = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > _velocityToDie)
        {
            Destroy(gameObject);
        }
    }
}
