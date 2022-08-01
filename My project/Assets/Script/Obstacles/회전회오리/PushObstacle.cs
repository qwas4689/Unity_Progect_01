using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObstacle : MonoBehaviour
{
    public Transform _obstacle;
    public Rigidbody _ri;
    private bool isMaxMove = false;
    private float moveMax = 13.2f;
    private Vector3 startObstacle;
    
    // Start is called before the first frame update
    void Start()
    {
        _ri = GetComponent<Rigidbody>();
        startObstacle = transform.position;
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
            _ri.AddForce(-7f, 0f, 0f);
            if (_obstacle.position.x <= startObstacle.x)
            {
                isMaxMove = false;
                _ri.velocity = Vector3.zero;
            }
        }
        else
        {
            _ri.AddForce(25f, 0f, 0f);

            if (_obstacle.position.x >= moveMax)
            {
                isMaxMove = true;
                _ri.velocity = Vector3.zero;
            }
        }
    }
}
