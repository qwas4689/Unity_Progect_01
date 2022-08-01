using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Renderer _colorChange;

    private float randNumX = 2f;
    private float randNumY = 2f;
    private float randNumZ = 2f;
    private float returnTime;

    // Start is called before the first frame update
    void Start()
    {
        _colorChange = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_colorChange.material.color == Color.red)
        {

            returnTime += Time.deltaTime;

            if (returnTime >= 2f)
            {
                randNumX = Random.Range(-2f, 2f);
                randNumY = Random.Range(-5f, 5f);
                randNumZ = Random.Range(-2f, 2f);

                returnTime = 0f;
            }
            gameObject.transform.Rotate(randNumX, randNumY, randNumZ);
        }
    }
}
