using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFixMoving : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public bool isMaxSpeed;

    public float Speed = 5f;

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
        FixWindmillObstacles();
    }

    void FixWindmillObstacles()
    {
        _targetPosition = Target.position;
        transform.RotateAround(_targetPosition, Vector3.up, Speed * Time.deltaTime);
    }
}
