using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{

    public GameObject target;
    

    // Update is called once per frame
    void Update()
    {
        //camera follows the player by 10%
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, .1f);
    }
}