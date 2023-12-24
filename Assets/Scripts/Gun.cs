using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject ShotPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            GameObject shotObject = Instantiate(ShotPrefab);
            shotObject.transform.position = this.gameObject.transform.position;

            Bullet bullet = shotObject.GetComponent<Bullet>();
            bullet.MoveVector = this.gameObject.transform.forward;
        }
        
    }
}
