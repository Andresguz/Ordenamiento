using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{
    public GameObject ObjetoMover;
    public Transform StarPoint;
    public Transform EndPoint;

    private Vector3 MoverHacia;
    [SerializeField]
    public float Velocidad;

    void Start()
    {
        MoverHacia = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoMover.transform.position = Vector3.MoveTowards(ObjetoMover.transform.position, MoverHacia, Velocidad * Time.deltaTime);
        if (ObjetoMover.transform.position == EndPoint.position)
        {
            MoverHacia = StarPoint.position;
        }
        if (ObjetoMover.transform.position == StarPoint.position)
        {
            MoverHacia = EndPoint.position;
        }
    }
}
