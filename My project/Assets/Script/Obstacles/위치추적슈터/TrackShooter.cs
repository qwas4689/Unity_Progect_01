using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackShooter : MonoBehaviour
{
    public GameObject TrackPrefab;
    public Transform Player;

    private float UsingTime;

        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UsingTime += Time.deltaTime;

        if (UsingTime >= 9.9f)
        {
            transform.LookAt(Player);
        }

        if (UsingTime >= 10f)
        {
            Instantiate(TrackPrefab, transform.position, transform.rotation);
            UsingTime = 0f;
        }
    }
}
