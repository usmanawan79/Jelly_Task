using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroyed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Destroyed()
 {
     yield return new WaitForSeconds(5f);
     Destroy(gameObject);
 }
}
