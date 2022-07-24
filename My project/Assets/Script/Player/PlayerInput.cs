using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour, IComponent<PlayerController>
{
    public Vector3 MoveVelocity { get; private set; }


    public void UpdateComponent(PlayerController owner)
    {
        UpdateVelocity();
    }

    private void UpdateVelocity()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool hasControl = !Mathf.Approximately(horizontal, 0f) || !Mathf.Approximately(vertical, 0f);
        MoveVelocity = hasControl ? new Vector3(horizontal, 0f, vertical).normalized : Vector3.zero;

    }
}
