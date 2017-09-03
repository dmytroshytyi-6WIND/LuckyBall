using UnityEngine;
using System.Collections;

public class reactionOpenGate : MonoBehaviour {

    public GameObject openGate;
  
    private int colliderCount = 0;
    void OnTriggerEnter(Collider other)
    {

        if (colliderCount == 0)
        {
            //animatedStairs.GetComponent<Animation>().Play();
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
			transform.GetComponent<Collider>().isTrigger = true;
            openGate.GetComponent<Collider>().isTrigger = true;
    
        }
        colliderCount++;
    }
    void OnTriggerExit(Collider other)
    {
         colliderCount--;
        if (colliderCount == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
			//transform.GetComponent<Collider>().isTrigger = false;
            openGate.GetComponent<Collider>().isTrigger = false;
    
        }
    }
     
    }
