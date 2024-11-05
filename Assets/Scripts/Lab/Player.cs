using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public Transform BulletSpawnPoint {  get; set; }
    [field: SerializeField] public GameObject Bullet {  get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    private void Update()
    {
        BulletTimer = Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && BulletTimer <= 0)
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
