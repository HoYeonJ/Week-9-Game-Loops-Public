using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVariable : MonoBehaviour
{
    List<GameObject> ObjectsToRotate { get; set; }
// a reference in the Inspector

void Start()
{
    ObjectsToRotate = GetComponent<RotateVariable>().ObjectsToRotate;
    for(int i =0; i<4;i++) {
        for(int j = 0; j<4; j++){
            //GameObject newcube = Instantiate(ObjectsToRotate[i*4+j]);
            ObjectsToRotate[i*4+j].transform.position = new Vector3(i*2f, j*2f, 0);
        }
    }
}

    // Update is called once per frame
    void Update()
    {
            for (int i =0; i< ObjectsToRotate.Count; i++)
            {
                ObjectsToRotate[i].transform.Rotate(.1f*i, 0, 0);
            }
    }
}