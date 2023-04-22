using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger1 : MonoBehaviour
{
    public Vector3 newCamPos, newPlayerPos;

    CamControl camControl;

    // Start is called before the first frame update
    void Start()
    {
        camControl = Camera.main.GetComponent<CamControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            camControl.minPos += newCamPos;
            camControl.maxPos += newCamPos;

            other.transform.position += newPlayerPos;
        }
    }
}
