using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("collided");
            //player.GetComponent<Rigidbody>().AddForce(100, 0, 0);
            //player.GetComponent<Rigidbody>().AddForce(Vector3.left * 1000.0f);
            //player.GetComponent<Transform>().Position(spawnPoint.position);
            //player.GetComponent<Transform>().Translate(Vector3.forward * Time.deltaTime);
            player.transform.position = spawnPoint.position;
        }
    }
}
