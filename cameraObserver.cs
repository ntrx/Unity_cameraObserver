using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraObserver : MonoBehaviour
{
    public GameObject target;
    float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform.position);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.parent.Rotate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
            transform.parent.Rotate(Vector3.down * speed);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.parent.Rotate(Vector3.right * speed);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.parent.Rotate(Vector3.left * speed);
    }
}
