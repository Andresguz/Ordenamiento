using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour
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

        starPosition = transform.position.y;
    }


    void Update()
    {

        counter += Time.deltaTime * speed;
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(counter, length) + starPosition);
        actualPosition = transform.position.x;
        //if (actualPosition < lastPosition) transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
        //if (actualPosition > lastPosition) transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        //lastPosition = transform.position.x;



    }
}
