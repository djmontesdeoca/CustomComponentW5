using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("rotation controls")]
    [Tooltip("the axis which the game obj is rotating")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    [Tooltip("the speed the game obj is rotating, measured in degrees")]
    [SerializeField]
    private float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
