using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;

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
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null)
            {
                //camControl.minPos += newCamPos;
                //camControl.maxPos += newCamPos;
                transform.position = currentTeleporter.GetComponent<Teleport>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleport>().GetDestination().position;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }
}
