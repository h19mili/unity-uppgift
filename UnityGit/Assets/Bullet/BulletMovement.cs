using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);


        /*if (transform.position.y >= 8 || transform.position.y <= -8)
        {
            Destroy(this.gameObject);
        }


        if (transform.position.x >= 8 || transform.position.y <= -8)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.z >= 8 || transform.position.z <= -8)
        {
            Destroy(this.gameObject);
        }*/


    }
}
