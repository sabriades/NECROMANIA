using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVETAG : MonoBehaviour
{
    public GameObject VD;
    public GameObject VD1;
    public float speed; 


  
    void Update()
    {

        VD.transform.position = Vector3.MoveTowards(VD.transform.position, VD1.transform.position, speed);
        
    }
}
