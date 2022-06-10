using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanegiment : MonoBehaviour
{
    [SerializeField] bool g_gameclear = false;
    [SerializeField] GameObject m_GamecrearText;
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
            g_gameclear = true;
            Text ClearText = m_GamecrearText.GetComponent<Text>();
            ClearText.text = "GameClear";


        }
    }
}
