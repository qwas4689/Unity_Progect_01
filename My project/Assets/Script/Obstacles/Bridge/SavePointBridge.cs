using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointBridge : MonoBehaviour
{
    public GameObject _target;
    private Rigidbody _rigidbody;
    private Vector3 SavePointMoveBridge;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        SavePointMoveBridge = _target.transform.position - transform.position;

        SavePointMoveBridge.y = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = SavePointMoveBridge * 5f * Time.deltaTime;
    }

}
