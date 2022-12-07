using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckManager : MonoBehaviour
{
   public static DuckManager instance;

   public int flyAways;

   public SpawnDuck duckSpawn;



    // Start is called before the first frame update
    void Start()
    {
        if(instance== null)
        {
            instance = this;
        }
    }

    public void AddFlyAway()
    {
        flyAways++;
        if(flyAways >= 2)
        {
            FlipControl();
            flyAways = 0;
        }
    }

    public void FlipControl()
    {
        ShiftInvert flip = new ShiftInvert();
        duckSpawn.currentSide = flip.ChangeControl();
        
    }
}
