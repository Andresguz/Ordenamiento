using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimeinto : MonoBehaviour
{
    [SerializeField]
    float velocidad = 3.0f;
    [SerializeField]
    float fuerzaSalto =20.0f;
    public Animator soldier;
    public bool dano = false;
    public bool llaveActiva = false;
  //  public GameObject puerta;
    void Start()
    {
      //  puerta.SetActive(false);

        soldier = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoPlayer();


    }
    void MovimientoPlayer()
    {
        if (dano == false)
        {
            soldier.SetBool("jump", false);
            soldier.SetBool("walk", false);
            soldier.SetBool("idle", false);
            soldier.SetBool("dano", false);
        }
        if (Input.GetKey("d"))
        {
           // soldier.SetBool("idle", false);
            soldier.SetBool("walk", true);

            transform.Translate(Vector2.right * Time.deltaTime * velocidad);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey("a"))
        {
            //soldier.SetBool("idle", false);
            soldier.SetBool("walk", true);
            transform.Translate(Vector2.left * Time.deltaTime * velocidad);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("q"))
        {
            soldier.SetBool("walk", false);
            soldier.SetBool("run", true);
            velocidad = 6.0f;
           
        }
        if (Input.GetKey("e"))
        {
            soldier.SetBool("walk", false);
            soldier.SetBool("run", false);
            soldier.SetBool("atack", true);
           // velocidad = 6.0f;

        }
        if (Input.GetKey("w") && Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.y) < 0.01f)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            soldier.SetBool("jump", true);
          //  soldier.SetBool("idle", false);

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cabeza")
        {
            Destroy(other.gameObject);
        }
       

    }
}
