using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Text txt;
    int s=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        s+=5;
        Debug.Log("Enter");
        if(other.gameObject.tag=="Score")
        {
            Debug.Log("Change");
            txt.text=s.ToString();
        }   
    }
}
