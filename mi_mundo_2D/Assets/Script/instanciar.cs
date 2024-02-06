using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTANCIAR : MonoBehaviour
{
    public GameObject target;
    public Vector3 positionToInstantine;
    public float timeUntilSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnObject", timeUntilSpawn); 
    }

    // Update is called once per frame
    void SpawnObject()
    {
        Instantiate(target, positionToInstantine, Quaternion.identity); 
    }
}
