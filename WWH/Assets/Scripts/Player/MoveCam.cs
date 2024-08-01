using System.Xml.Serialization;
using UnityEditor.Rendering;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public Transform cameraPosition;
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
