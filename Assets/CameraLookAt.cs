using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;

    [Range(1f, 100f)]
    [SerializeField]
    private float sensitivity = 10.0f;
    [Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
    [Range(0f, 90f)] [SerializeField] float yRotationLimit = 88f;

    // Update is called once per frame
    void Update()
    {
        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);

        transform.localEulerAngles = new Vector3(-rotation.y, rotation.x, 0);
    }
}
