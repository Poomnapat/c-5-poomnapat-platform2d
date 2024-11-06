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
        Speed = 4.0f;
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
    
    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        Debug.Log($"Banana is move with speed {speed} using Transform");
    }

    private void FixedUpdate()
    {
        
    }

    public void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
