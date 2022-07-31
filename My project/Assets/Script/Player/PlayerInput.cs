using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Zmoving { get; private set; }
    public float Xmoving { get; private set; }

    public bool Runing { get; private set; }
    public bool Jumping { get; private set; }
    public bool Rolling { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Zmoving = Xmoving = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Zmoving = Input.GetAxis("Vertical");
        Xmoving = Input.GetAxis("Horizontal");
        Runing = Input.GetButton("Fire1");

        Jumping = Input.GetButtonDown("Jump");
        Rolling = Input.GetButton("Fire3");
    }
}
