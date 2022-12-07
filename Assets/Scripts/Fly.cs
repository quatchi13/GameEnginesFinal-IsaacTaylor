using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,3,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >9 || transform.position.y < -6)
        {
            gameObject.SetActive(false);
        }
    }
}
