using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    [SerializeField] int _hp = 10;
    [SerializeField] Image _GameOverText;
    [SerializeField] Text _Life;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _Life.text = $"HP:{_hp}";
        if (_hp < 1)
        {
            _GameOverText.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            _hp -= 1;
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            _hp -= 2;
        }
    }
}

