using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private int damage;
    protected string owner;
    public abstract void Move();
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    /*OnHitWith
    public void OnHitWith(Character)
    {

    }*/

    public int GetShootDirection()
    {
        return 1;
    }
}

