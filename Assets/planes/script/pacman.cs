using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacman : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    void Start()
    {
        Debug.Log("w:" + mainCamera.pixelWidth + " h:" + mainCamera.pixelHeight);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, mainCamera.pixelHeight / 2)).x);
        if(mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, mainCamera.pixelHeight / 2)).x > 20.5f ||
           mainCamera.ScreenToWorldPoint(new Vector3(0, mainCamera.pixelHeight / 2)).x < -20.5f)
        {
            Debug.Log("tp_to: " + new Vector3(-transform.position.x, transform.position.y, transform.position.z).ToString());
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
        if(mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth/2, mainCamera.pixelHeight)).y > 10.25f ||
           mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, 0)).y < -10.25f)
        {
            Debug.Log("tp_to: " + new Vector3(-transform.position.x, transform.position.y, transform.position.z).ToString());
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
