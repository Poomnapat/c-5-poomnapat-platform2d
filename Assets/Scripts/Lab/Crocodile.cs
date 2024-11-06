using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public float BulletSpawnTime { get; set; }
    [field: SerializeField] public float BulletTimer { get; set; }

    void Start()
    {
        Init(30);
        WaitTime = 0.0f;
        ReloadTime = 5.0f;
        DamageHit = 30;
        attackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
    }

    public void Update()
    {       
        BulletTimer -= Time.deltaTime;

        Behavior();
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
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
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Rock rock = obj.gameObject.GetComponent<Rock>();
            rock.Init(20, this);

            WaitTime = 0;        
    }
}
