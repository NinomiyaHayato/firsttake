using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiochange : MonoBehaviour
{
    [SerializeField] AudioSource _BGM1;
    [SerializeField] AudioSource _BGM2;
    // Start is called before the first frame update
    void Start()
    {
        _BGM1.GetComponent<AudioSource>();
        _BGM2.GetComponent<AudioSource>();
        _BGM1.Play();

    }

    // Update is called once per frame
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "shark")
        {
            _BGM1.Stop();
            _BGM2.Play();
        }

    }
}
