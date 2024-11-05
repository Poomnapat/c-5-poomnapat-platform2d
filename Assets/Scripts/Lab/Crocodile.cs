using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    public void Update()
    {
        BulletTimer -= Time.deltaTime;

        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance <= attackRange && BulletTimer <= 0)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
        BulletTimer = BulletSpawnTime;
    }
}
