﻿//Source : http://pastebin.com/dcQYCvxG

using UnityEngine;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class ArcBall : MonoBehaviour
{
    public float radius = 5.0f,
            minRadius = 1.5f,
            maxRadius = 10.0f,
            scale = 0.002f;
    public GameObject target;
    private float targetRadius = 8.0f,
            mouseX = 0.0f,
            mouseZ = 0.0f;
    private Vector3 up = new Vector3(0.0f, 1.0f, 0.0f),
            right = new Vector3(0.0f, 0.0f, 1.0f),
            newPosition = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        this.transform.position = new Vector3(radius, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        if (Input.GetMouseButton(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                mouseX = Input.GetAxis("Mouse X");
                mouseZ = Input.GetAxis("Mouse Y");
            }    
        }

        newPosition += right * mouseX * radius / 4.0f
                + up * mouseZ * -radius / 4.0f;
        newPosition.Normalize();
        right = Vector3.Cross(up, newPosition);
        up = Vector3.Cross(newPosition, right);

        right.Normalize();
        up.Normalize();

        if (Input.GetAxis("Mouse ScrollWheel") > 0.0f)
        {
            targetRadius = Mathf.Max(targetRadius / 1.1f, minRadius);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0.0f)
        {
            targetRadius = Mathf.Min(targetRadius * 1.1f, maxRadius);
        }
        radius = Mathf.Lerp(radius, targetRadius, 0.1f);
        newPosition.Normalize();
        transform.position = newPosition * radius;
        transform.LookAt(new Vector3(0.0f, 0.0f, 0.0f), up);
    }
}