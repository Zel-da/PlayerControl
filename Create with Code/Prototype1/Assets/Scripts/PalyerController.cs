using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalyerController : MonoBehaviour
{
    public float speed = 20;

    void Start()
    {
        
    }

    void Update()
    {
        //차량 전진
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
