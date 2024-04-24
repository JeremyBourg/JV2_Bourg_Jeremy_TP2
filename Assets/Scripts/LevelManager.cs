using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [SerializeField]
    private LevelInfo levelInfo;

    public void PickUpObject(Component sender, object data){
        Debug.Log("Score: " + data);
        
        levelInfo.nbrObjectsCollected++;
    }
}
