using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed;
    public GameObject player;
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
            tempBullet= Instantiate(bulletPrefab,transform.position, Quaternion.identity); //No rotation
            tempBullet.transform.position = transform.position;
            Camera camera = GetComponentInChildren<Camera>();
            
            tempBullet.GetComponent<Rigidbody>().velocity = camera.transform.rotation * Vector3.forward * speed  ;
            //tempBullet.transform.position = player.transform.position;

        }
        
    }
    
}
