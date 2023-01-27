using UnityEngine;

public class CrossSectionPlane : MonoBehaviour
{
    public Material mat1;
    void Update()
    {
        mat1.SetVector("_PlanePosition", transform.position);
        mat1.SetVector("_PlaneNormal", transform.forward);
    }
}