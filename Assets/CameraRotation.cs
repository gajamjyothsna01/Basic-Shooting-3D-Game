using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float mousex, mousey;
        
        mousex = Input.GetAxis("Mouse X");
       
        mousey = Input.GetAxis("Mouse Y");

        //transform.rotation = Quaternion.Euler(0, 90, 0) * Quaternion.Euler(0, 30, 0); //It always shows 120
        transform.rotation = transform.rotation * Quaternion.Euler(0, mousex*rotationSpeed , 0);
        //transform.rotation = transform.rotation * Quaternion.Euler(mousex, 0, 0);
        Camera camera = GetComponentInChildren<Camera>();
        camera.transform.localRotation = Quaternion.Euler(-mousey, 0, 0) * camera.transform.localRotation;
          
        
    }
}
