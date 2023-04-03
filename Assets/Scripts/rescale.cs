using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescale : MonoBehaviour
{

    private Vector3 scaleChange, positionChange;
    [SerializeField] float speed;
    float scale_0= 0.00f;
    float scale_1 = 0.002f;
    float scale_3 = 0.0003f;
    float maxScale = 1.0f;
    float minScale = 0.1f;



    void Awake()
    {
        



        scaleChange = new Vector3(-scale_1, -scale_1, -scale_1);
        positionChange = new Vector3(scale_0, -scale_3, scale_0);
    }

    void Update()
    {
        transform.localScale += scaleChange*speed;
        transform.position += positionChange*speed;


        if (transform.localScale.y < minScale || transform.localScale.y > maxScale)
        {
            scaleChange = -scaleChange;
            positionChange = -positionChange;
        }
    }
}