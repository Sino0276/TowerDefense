using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slime : Enemy, IAbility
{
    
    //private Enemy enemy;
    public GameObject prefab;

    public void init()
    {
        name = "Slime";
        if (size == 0)
            size = 1;
        Dmg = 1;
        Hp = size * 5;
    }

    public void ability() 
    {
        // if ((this.IsDestroyed() || transform.IsDestroyed()) && size > 0)
        // {
        //     Instantiate(prefab);
        // }
    }
    
}
