using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class vida : MonoBehaviour
{
    int tiempo=4;
    [SerializeField]
    Text textovidas; 
    [SerializeField]
    Text textoCoin;
    [SerializeField]
    public int vidas = 3;
    public int coin = 0;
    Animator megaman;
    public MOVEMENT mov;
    public GameController controller;
        void Start()
    {
        coin = controller.Monedas();
        vidas = controller.Vidas();
        textovidas.text = vidas.ToString();
        textoCoin.text = coin.ToString();
        megaman = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (vidas <=0)
        {
            SceneManager.LoadScene(3);
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trampa" || collision.gameObject.tag == "enemigo")
        {
            vidas -= 1;
            StartCoroutine("TiempoDano");
            textovidas.text = vidas.ToString();
        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="coin")
        {
            coin += 1;
            textoCoin.text = coin.ToString();
            Destroy(collision.gameObject);
        }
    }

    IEnumerator TiempoDano()
    {
        mov.dano = true;
        megaman.SetBool("jump", false);
        megaman.SetBool("walk", false);
        megaman.SetBool("idle", false);
        megaman.SetBool("dano", true);
        yield return new WaitForSeconds(1);
        mov.dano = false;
        megaman.SetBool("dano", false);
    }
}
