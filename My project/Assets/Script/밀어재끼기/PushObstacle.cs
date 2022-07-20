using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObstacle : MonoBehaviour
{
    public Transform _obstacle;
    public Rigidbody _ri;

    private bool isMaxMove = false;

    // Start is called before the first frame update
    void Start()
    {
        _ri = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Push();
    }
    void Push()
    {
        _obstacle.Rotate(0f, 5f, 0f);

        if (isMaxMove)
        {
            _ri.AddForce(-5f, 0f, 0f);
            if (_obstacle.position.x <= 10f)
            {
                isMaxMove = false;
                _ri.velocity = Vector3.zero;
            }

        }
        else
        {
            _ri.AddForce(70f, 0f, 0f);

            if (_obstacle.position.x >= 100f)
            {
                isMaxMove = true;
                _ri.velocity = Vector3.zero;

            }
        }
    }
}
