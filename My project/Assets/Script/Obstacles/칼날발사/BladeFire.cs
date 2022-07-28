using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeFire : MonoBehaviour
{
    public Rigidbody _riBullet;

    private float destroyTime = 2f;
    private float bulletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _riBullet = GetComponent<Rigidbody>();

        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        _riBullet.velocity = new Vector3(bulletSpeed, 0f, 0f);

    }
}
