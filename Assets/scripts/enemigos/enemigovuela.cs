using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigovuela : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.2f;
    [SerializeField]
    public float length = 1;
    private float counter;
    private float starPosition;
    [SerializeField]
    public float scala=0.8f;
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
        if (actualPosition < lastPosition) transform.localScale = new Vector3(-scala, scala, scala);
        if (actualPosition > lastPosition) transform.localScale = new Vector3(scala, scala, scala);
        lastPosition = transform.position.x;

    }
}
