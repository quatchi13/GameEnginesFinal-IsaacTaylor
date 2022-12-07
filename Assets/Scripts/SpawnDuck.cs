using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDuck : MonoBehaviour
{
    public List<GameObject> duckPond;

    public GameObject duckPrefab;

    public KeyCode currentSide = KeyCode.LeftShift;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(currentSide))
        {
            
            Spawn();
        }

        else if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            SpawnNew();
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

    public void SpawnNew()
    {
        Vector3 spawnPoint = new Vector3(0,-6,0); 
        GameObject duck = Instantiate(duckPrefab,spawnPoint, Quaternion.identity);
        duck.GetComponent<Rigidbody>().velocity = new Vector3(0,3,0);
    }
}
