using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilliator : MonoBehaviour
{
    [Header("Movement Params")]
    //    [SerializeField]
    public Vector3 movementAxis;

//    [SerializeField]
    public float movementSpeed;

    //    [SerializeField]
    public float movementDistance;

    [Header("Movement Positions")]
    //    [SerializeField]
    public Vector3 startingPosition;

    //    [SerializeField]
    public Vector3 posEnd;

    //    [SerializeField]
    public Vector3 negEnd;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        // the direction of movement
        direction = movementAxis.normalized;

        // precompute positions
        startingPosition = transform.position;
        posEnd = transform.position + (direction * movementDistance);
        negEnd = transform.position - (direction * movementDistance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // once bound is reached, reverse the movement to the other direction
        if(Vector3.Distance(transform.position, posEnd) <= 0.01f || Vector3.Distance(transform.position, negEnd) <= 0.01f)
            direction *= -1;

        transform.Translate(direction * movementSpeed * Time.deltaTime);    
    }
}
