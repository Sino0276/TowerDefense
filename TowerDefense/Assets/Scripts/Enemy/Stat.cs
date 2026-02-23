using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    protected int hp;
    protected int HP { get => hp; set => hp = value; }
    protected int damage;
    protected int speed;

    public void setHP(int hp)
    {
        HP = hp;
    }
}
