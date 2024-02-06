using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject otherObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            {
                Destroy(gameObject);
            }

        if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            Destroy(otherObject);
        }
        if (Input.GetKeyUp(KeyCode.RightShift)) 
        {
            Destroy(otherObject.GetComponent<Collider>());
        }

    }
}
