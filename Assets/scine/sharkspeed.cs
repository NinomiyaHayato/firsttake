using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkspeed : MonoBehaviour
{
    [SerializeField] float _speed;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
      _rb = this.transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.velocity= Vector2.up.normalized * _speed;
    }
}
