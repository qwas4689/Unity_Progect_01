using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackBullet : MonoBehaviour
{
    private float destroyTime = 10f;
    private float bulletSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed * Time.deltaTime);
    }
}
