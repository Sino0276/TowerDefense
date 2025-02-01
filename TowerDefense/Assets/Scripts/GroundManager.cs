using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public static GroundManager instance;
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Ground manager in scene!");
            return;
        }
        instance = this;
    }


    public GameObject[] grounds;

    // public void addlist()
    // {
    //     grounds.
    // }
}
