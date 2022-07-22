using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public string ZMove = "Vertical";
    public string XMove = "Horizontal";
    public string Jump = "Jump";
    public string Roll = "Fire3";

    public float Move { get; private set; }
    public float Rotate { get; private set; }
    public bool Jumping { get; private set; }
    public bool Rolling { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Rotate = Move = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate = Input.GetAxis(XMove);
        Move = Input.GetAxis(ZMove);
        Jumping = Input.GetButton(Jump);
        Rolling = Input.GetButton(Roll);
    }
}
