using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanegiment : MonoBehaviour
{
    [SerializeField] Image _gameclear;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="goal")
        {
            
            _gameclear.gameObject.SetActive(true);

        }
    }
    
}
