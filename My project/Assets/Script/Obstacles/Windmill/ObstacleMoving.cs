using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool isMaxSpeed;

    private float Speed;
    private float MaxSpeed = 300f;
    private float MinSpeed = 0f;

    public Transform Target;

    private Vector3 _targetPosition;

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
       
        _targetPosition = Target.transform.position;
        transform.RotateAround(_targetPosition, Vector3.up, Speed * Time.deltaTime);

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
