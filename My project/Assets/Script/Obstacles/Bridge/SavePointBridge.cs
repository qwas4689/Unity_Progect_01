using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointBridge : MonoBehaviour
{
    public GameObject _target;
    public GameObject _startTarget;

    private Rigidbody _rigidbody;
    private Vector3 SavePointMoveBridge;
    Vector3 aaa;
    public bool onoff;
    // Start is called before the first frame update
    void Start()
    {
        onoff = false;
        _rigidbody = GetComponent<Rigidbody>();

        SavePointMoveBridge = _target.transform.position - transform.position;

        // SavePointMoveBridge.y = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(onoff)
        {
        aaa = transform.position = Vector3.MoveTowards(_startTarget.transform.position, _target.transform.position, 10f);

        }
        else
        {
            aaa = transform.position = Vector3.MoveTowards(_target.transform.position,_startTarget.transform.position,  10f);
        }
        _rigidbody.velocity = aaa * 1f * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Platform")
        {

            onoff = !onoff;
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Platform")
    //    {
            
    //        onoff = !onoff;
    //    }
    //}
}
