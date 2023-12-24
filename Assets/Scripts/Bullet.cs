using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float Speed = 10;
    public float Damage = 10;
    public Vector3 MoveVector = new Vector3();

    // Start is called before the first frame update
    private void Start()
    {
        // 5秒後に消滅
        Destroy(gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MoveVector * Speed * Time.deltaTime;
    }

    /// <param name="other">
    private void OnTriggerEnter(Collider other)
    {
        Health health = other.gameObject.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(Damage);
            Destroy(this.gameObject);
        }
    }
}
