using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdles : MonoBehaviour
{
    public GameObject[] hurdles; 

    Vector3 V;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Hurdle",5.0f,2.0f);
        
       
    }

    // Update is called once per frame
    void Update()
    {
      V= new Vector3(-3.0f,6.55f,2.2f);
      
    }

    void Hurdle()
    {
        //V+=transform.postion(1.0f,1.0f,1.0f);
        int rand=Random.Range(0,2);
        Instantiate(hurdles[rand],transform.position+V,Quaternion.identity);
    }


}
