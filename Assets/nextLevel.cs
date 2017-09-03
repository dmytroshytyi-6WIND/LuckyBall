using UnityEngine;
using System.Collections;


public class nextLevel : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        //Application.LoadedLevel(2);
        Timer.Stop();
        Application.LoadLevel(1);
        
    }
}
