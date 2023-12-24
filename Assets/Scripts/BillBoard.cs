using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main)
        {
            Vector3 p = Camera.main.transform.position;

            p.y = this.gameObject.transform.position.y;

            this.gameObject.transform.LookAt(p);
        }
    }
}
