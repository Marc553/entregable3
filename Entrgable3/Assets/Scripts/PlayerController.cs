using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += new Vector3(2, 2, 2);
        }
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation *= Quaternion.Euler(45, 0, 45);
        }
    }
}
