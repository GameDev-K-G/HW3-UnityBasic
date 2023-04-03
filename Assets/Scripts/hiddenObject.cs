using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenObject : MonoBehaviour
{
       public GameObject bomb_ground_4 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bomb_ground_4.SetActive(false);
        
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            bomb_ground_4.SetActive(true);
       
        }
    }
}