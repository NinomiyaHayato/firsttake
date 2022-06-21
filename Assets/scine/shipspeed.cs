using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipspeed : MonoBehaviour
{
    [SerializeField] float _speed;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = Vector2.down.normalized * _speed ;
    }
}
