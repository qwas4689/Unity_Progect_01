using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    Camera _camera;

    private void Start()
    {
        _camera = GetComponent<Camera>();
    }


}
