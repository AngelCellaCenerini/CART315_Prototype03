using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNote : MonoBehaviour
{
    public GameObject noteCloseUp;
    public GameObject instructions;
    public GameObject note;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (!note.activeSelf && !instructions.activeSelf && noteCloseUp.activeSelf)
             {
                note.SetActive(true);
                instructions.SetActive(true);
                noteCloseUp.SetActive(false);
             }

        }  
    }

}
