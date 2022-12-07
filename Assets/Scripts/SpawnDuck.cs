using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public List<GameObject> duckPond;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            Spawn();
        }
    }

    public void Spawn()
    {
        
        for(int count = 0; count < duckPond.Count; count++)
        {
            Debug.Log("Checking Duck " + count);
            if(!duckPond[count].activeSelf)
            {
                Debug.Log("Duck Found");
                duckPond[count].transform.position = new Vector3(0,-6, 0);
                duckPond[count].GetComponent<Rigidbody>().velocity = new Vector3(0,3,0);
                duckPond[count].SetActive(true);
                break;
            }
        }
    }
}
