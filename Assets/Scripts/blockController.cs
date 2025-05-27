using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockController : MonoBehaviour
{

   
    private void OnTriggerEnter(Collider collision)
    {
        if(collision != null && collision.gameObject.tag == "DestroyBlock")
        {
            Destroy(gameObject);
        }
    }
}
