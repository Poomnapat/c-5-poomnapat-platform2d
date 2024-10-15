using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    [SerializeField] private int damage;
    public Animator anim;
    public Rigidbody2D rb2d;
    [SerializeField] private Vector2 force;
    private void Start()
    {
        Move();
        Damage = 40;
    }

    public Rock()
    {
        Damage = 40; 
    }
    public override void Move()
    {
        {
            Debug.Log($"Rock is moving by applying RigidBody force");           
        }
    }
    /*OnHitWith
    public void OnHitWith(Character)
    {

    }*/
    
}
