using BirdScripts;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdShoot : MonoBehaviour
{
    public Rigidbody2D _slingRb;

    [SerializeField] private BirdSpawn _birdSpawn;
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
            if (Vector2.Distance(_mousePosition, _slingRb.position) > _maxDistanceToPool)
            {
                _rb.position = _slingRb.position + (_mousePosition - _slingRb.position).normalized * _maxDistanceToPool;
            } else
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
