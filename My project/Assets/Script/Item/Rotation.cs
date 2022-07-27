using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform _object;
    
    private float randNumX = 2f;
    private float randNumY = 2f;
    private float randNumZ = 2f;
    private float returnTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        returnTime += Time.deltaTime;

        if (returnTime >= 2f)
        {
            randNumX = Random.Range(-2f, 2f);
            randNumY = Random.Range(-5f, 5f);
            randNumZ = Random.Range(-2f, 2f);

            returnTime = 0f;
        }
        _object.Rotate(randNumX, randNumY, randNumZ);
    }
}
