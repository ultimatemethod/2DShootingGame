using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider otherObject)
    {
       if (otherObject.tag == "DestroyZone")
        {
            return;
        }
       
       Destroy(otherObject.gameObject);
        
    }
    
}
