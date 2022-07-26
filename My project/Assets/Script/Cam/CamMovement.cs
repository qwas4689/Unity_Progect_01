using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform _objectToFollow;
    private float CamFollowSpeed = 10f;
    private float CamSensitivity = 450f;
    private float CamAngle = 60f;

    private float MouseRotationX;
    private float MouseRotationY;

    public Transform Cam;
    private Vector3 DirNormarized;
    private Vector3 FinalDir;
    private float MinDistance = 2f;
    private float MaxDistance = 5f;
    private float FinalDistance;
    private float Smoothness = 10f;

    // Start is called before the first frame update
    void Start()
    {
        MouseRotationX = transform.localRotation.eulerAngles.x;
        MouseRotationY = transform.localRotation.eulerAngles.y;

        DirNormarized = Cam.localPosition.normalized;
        FinalDistance = Cam.localPosition.magnitude;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MouseRotationX += -(Input.GetAxisRaw("Mouse Y")) * CamSensitivity * Time.deltaTime;
        MouseRotationY += Input.GetAxisRaw("Mouse X") * CamSensitivity * Time.deltaTime;

        MouseRotationX = Mathf.Clamp(MouseRotationX, -CamAngle, CamAngle);

        Quaternion _rotation = Quaternion.Euler(MouseRotationX, MouseRotationY, 0);
        transform.rotation = _rotation;

    }

    void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _objectToFollow.position, CamFollowSpeed * Time.deltaTime);

        FinalDir = transform.TransformPoint(DirNormarized * MaxDistance);

        RaycastHit hit;

        if (Physics.Linecast(transform.position, FinalDir, out hit))
        {
            FinalDistance = Mathf.Clamp(hit.distance, MinDistance, MaxDistance);
        }
        else
        {
            FinalDistance = MaxDistance;
        }

        Cam.localPosition = Vector3.Lerp(Cam.localPosition, DirNormarized * FinalDistance, Time.deltaTime * Smoothness);
    }
}
