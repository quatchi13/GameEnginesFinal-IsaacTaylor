using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zapper : MonoBehaviour
{

    public List<GameObject> duckPond;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Pew();
        }
    }

    public void Pew()
    {
        for(int count = 0; count < duckPond.Count; count++)
        {
            if(duckPond[count].activeSelf && duckPond[count].GetComponent<Rigidbody>().velocity.y >0)
            {
                duckPond[count].GetComponent<Rigidbody>().velocity *= -1;
                
            }
        }
    }
}
