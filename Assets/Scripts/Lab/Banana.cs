using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{

    [SerializeField] private int damage;
    [SerializeField] private float speed;
    private void Start()
    {
        Move();
        Speed = 4;
        Damage = 30;
    }
    public float Speed
    {
        get { return speed; }
        set
        {
            speed = value * 4;

            Vector3 scale = transform.localScale;
            scale.x *= 4;
            transform.localScale = scale;
        }
    }

    public Banana()
    {
        Damage = 30;
    }
    
    public override void Move()
    {
        Debug.Log($"Banana is move with speed {speed} using Transform");
    }
    /*OnHitWith
    public void OnHitWith(Character)
    {

    }*/
}
