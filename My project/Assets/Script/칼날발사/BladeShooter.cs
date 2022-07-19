using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeShooter : MonoBehaviour
{
    public GameObject BladePrefab;

    private float UsingTime;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsingTime += Time.deltaTime;

        if (UsingTime >= 0.8f)
        {
            Instantiate(BladePrefab, transform.position, transform.rotation);
            UsingTime = 0f;
        }
    }
}
