using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{    public GameObject plane;
    Vector3 VP;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(ground());
         StartCoroutine(Destroyed());
    }

    // Update is called once per frame
    void Update()
    {
        VP=new Vector3(-40.0f,0.0f,0.0f);
    }
    IEnumerator ground()
    {
        yield return new WaitForSeconds(8f);
        Instantiate(plane,transform.position+VP,Quaternion.identity);
    }
     IEnumerator Destroyed()
 {
     yield return new WaitForSeconds(18f);
     Destroy(gameObject);
 }
}
