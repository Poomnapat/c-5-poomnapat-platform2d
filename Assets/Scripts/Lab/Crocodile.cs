using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField] private float attackRange;
    public Player player;

    [SerializeField] private GameObject bullets;
    [SerializeField] private Transform bulletsSpawnPoint;

    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletsTimer;

    private void Update()
    {
        bulletsTimer -= Time.deltaTime;

        Behavior();
    }
    public override void Behavior()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (bulletsTimer <= 0)
        {
            Instantiate(bullets, bulletsSpawnPoint.position, Quaternion.identity);

            bulletsTimer = bulletSpawnTime;
        }
    }
}
