using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpcontroll : MonoBehaviour
{
    [SerializeField] int _hp = 0;
    [SerializeField] Image _life;
    [SerializeField] Image _gameover;
    [SerializeField] Image _lifemax;
    [SerializeField] Image _lifezero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_hp <= 0)
        {
            Destroy(this.gameObject);
            _gameover.gameObject.SetActive(true);
            _lifemax.gameObject.SetActive(false);
            _lifezero.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            _hp -= 1;
            Life(0.2f);
        }
        if(collision.gameObject.tag == "enemy2")
        {
            _hp -= 2;
            Life(0.4f);
        }
        if(collision.gameObject.tag == "shark")
        {
            _hp -= 5;
            Life(1f);
        }
        if(collision.gameObject.tag == "goal")
        {
            _hp = 100;
        }
    }
    void Life(float life)
    {
        _life.GetComponent<Image>().fillAmount -= life;
    }
}
