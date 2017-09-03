using UnityEngine;
using System.Collections;


public class fallenBall : MonoBehaviour {
   GameObject finishGO;
	
	void Start() 
	{
    // finishGO = GameObject.Find("FinnishLine");
	}
    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(2);
		//finishGO.GetComponent(typeOf(FinnishLine)).startTime = 0;
			
    }
}

