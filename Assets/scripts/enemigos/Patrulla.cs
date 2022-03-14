using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.2f;
    [SerializeField]
    public float length = 1;
    private float counter;
    private float starPosition;

    private float actualPosition;
    private float lastPosition;

   
    void Start()
    {
         starPosition = transform.position.x;
       
    }

  
    void Update()
    {
       
            counter += Time.deltaTime * speed;
            transform.position = new Vector2(Mathf.PingPong(counter, length) + starPosition, transform.position.y);
            actualPosition = transform.position.x;
            if (actualPosition < lastPosition) transform.localScale = new Vector3(-11f, 11f, 11f);
            if (actualPosition > lastPosition) transform.localScale = new Vector3(11f, 11f, 11f);
            lastPosition = transform.position.x;

    }
}
