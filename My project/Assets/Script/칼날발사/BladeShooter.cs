using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeShooter : MonoBehaviour
{
    public GameObject BladePrefab;

    private float UsingTime;
    private float ShootBladeTime = 1f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsingTime += Time.deltaTime;


        if (UsingTime >= ShootBladeTime)
        {
            ShootBladeTime = Random.Range(0.5f, 1.5f);
            Instantiate(BladePrefab, transform.position, transform.rotation);
            UsingTime = 0f;
        }
    }
}
