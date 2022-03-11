using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    public Quaternion originalRotationValue;
    float rotationResetSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        originalRotationValue = transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            //this.transform.position = spawnPoint.position;
            //this.transform.rotation = spawnPoint.rotation;
            //transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
            Debug.Log("collided");
        }

    }
}
