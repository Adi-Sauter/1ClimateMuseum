using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject targetinSim;
    public GameObject targetinMus;
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collision with " + other.gameObject.name);
        if(other.gameObject.CompareTag("toSimulator"))
        {
            //Debug.Log("if-case: Collision with " + other.gameObject.name);
            this.transform.localPosition = new Vector3(targetinSim.transform.position.x, this.transform.position.y, targetinSim.transform.position.z);
        } else if(other.gameObject.CompareTag("toMuseum"))
        {
            //Debug.Log("elseif-case: Collision with " + other.gameObject.name);
            this.transform.localPosition = new Vector3(targetinMus.transform.position.x, this.transform.position.y, targetinMus.transform.position.z);
        }
    }
}
