using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT : MonoBehaviour
{
    [SerializeField]
    float velocidad = 3.0f;
    [SerializeField]
    float fuerzaSalto = 5.0f;
    public Animator megaman;
    public bool dano = false;
    public bool llaveActiva = false;
    public GameObject puerta;
    void Start()
    {
        puerta.SetActive(false);

        megaman = GetComponent<Animator>();
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
            megaman.SetBool("jump",false);
            megaman.SetBool("walk",false);
            megaman.SetBool("idle",false);
            megaman.SetBool("dano",false);
        }
        if (Input.GetKey("d"))
        {
            megaman.SetBool("idle", false);
            megaman.SetBool("walk", true);

            transform.Translate(Vector2.right * Time.deltaTime * velocidad);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey("a"))
        {
            megaman.SetBool("idle", false);
            megaman.SetBool("walk", true);
            transform.Translate(Vector2.left * Time.deltaTime * velocidad);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("w") && Mathf.Abs(gameObject.GetComponent<Rigidbody2D>().velocity.y) < 0.01f)
        {
           
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            megaman.SetBool("jump", true);
            megaman.SetBool("idle", false);
            
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
        if (other.gameObject.tag =="llave")
        {
            llaveActiva = true;
            Destroy(other.gameObject);
            puerta.SetActive(true);
        }

    }

    //  IEnumerator TiempoDamage(){
    //}
}
