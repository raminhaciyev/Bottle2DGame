using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public float speed;
    public Transform bottle;
  

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        float xPosition = Random.Range(-6f, 6f);

        if (collision.gameObject.tag=="Bottle")
        {
            bottle.position = new Vector3(xPosition, 7f, 0f);
        }
    }
}
