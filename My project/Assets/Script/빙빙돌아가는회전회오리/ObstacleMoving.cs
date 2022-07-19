using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public bool isMaxSpeed = false;
    
    public float Speed;
    public float MaxSpeed = 500f;
    public float MinSpeed = 0f;

    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        WindmillObstacles();


    }

    void WindmillObstacles()
    {
        transform.RotateAround(Target.transform.position, Vector3.forward, Speed * Time.deltaTime);

        if (!isMaxSpeed)
        {
            ++Speed;
            if (Speed >= MaxSpeed)
            {
                Speed = MaxSpeed;
                isMaxSpeed = true;
            }
        }
       
        else
        {
            --Speed;
            if (Speed <= MinSpeed)
            {
                Speed = MinSpeed;
                isMaxSpeed = false;
            }
        }
    }
}
