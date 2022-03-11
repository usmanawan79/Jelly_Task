using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime*4.0f;
        if(Input.GetKeyDown("space"))
        {
            transform.Rotate(90.0f, 0.0f, 0.0f);
        }
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Hurdle")
        {
            SceneManager.LoadScene(1);
        }
    }
}
