using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLine : MonoBehaviour
{
    public Transform bottle;

      void OnCollisionEnter(Collision collision)
    {
        float xPosition = Random.Range(-6f,6f);
        if (collision.gameObject.tag=="Barrier")
        {
            bottle.position = new Vector3(xPosition, 7f, 0f);
        }
    }
}
