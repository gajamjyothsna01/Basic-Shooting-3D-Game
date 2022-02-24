using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBullet;
            tempBullet = Instantiate(bulletPrefab,transform.position, Quaternion.identity); //No rotation
            tempBullet.GetComponent<Rigidbody>().velocity = Vector3.forward * speed;

        }
        
    }
    
}
