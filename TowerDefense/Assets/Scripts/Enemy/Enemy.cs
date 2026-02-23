using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform transform;
    
    [SerializeField] private string name;
    public string Name { get => name; set => name = value; }

    protected internal int Hp {get; set;}
    public int Dmg {get; set;}
    public int Speed {get; set;}
    public int Cost {get; set;}
    public int Value {get; set;}
    
    protected internal int size {get; set;}
    //private Status status;

    private void Start()
    {
        transform = gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        
    }


    private bool TakeDamage(int damage)
    {
        Hp -= damage;
        if (Hp <= 0)
        {
            Destroy(gameObject);
            return true;
        }

        return false;
    }

}
