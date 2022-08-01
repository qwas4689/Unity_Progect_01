using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeShooter : MonoBehaviour
{
    public GameObject BridgePrefab;

    private float UsingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsingTime += Time.deltaTime;


        if (UsingTime >= 3f)
        {
            Instantiate(BridgePrefab, transform.position, transform.rotation);
            UsingTime = 0f;
        }
    }
}
