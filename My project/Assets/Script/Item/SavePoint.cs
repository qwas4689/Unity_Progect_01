using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private Renderer _colorChange;

    // Start is called before the first frame update
    void Start()
    {
        _colorChange = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (_colorChange.material.color != Color.red)
                _colorChange.material.color = Color.red;
        }
    }

}
