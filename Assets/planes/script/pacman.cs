using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class pacman : MonoBehaviour
{
    [SerializeField] public Camera mainCamera;
    [SerializeField] public float bump_x;
    [SerializeField] public float bump_y;
    private bool flipped = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth, mainCamera.pixelHeight / 2)).x > 20.5f ||
           mainCamera.ScreenToWorldPoint(new Vector3(0, mainCamera.pixelHeight / 2)).x < -20.5f)
        {
            transform.position = new Vector3(-transform.position.x + Mathf.Sign(transform.position.x) * bump_x, transform.position.y, transform.position.z);
        }

        if (!flipped)
        {
            if (mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, mainCamera.pixelHeight)).y > 10.25f || mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, 0)).y < -10.25f)
            {
                transform.position = new Vector3(-transform.position.x, transform.position.y - Mathf.Sign(transform.position.y) * bump_y, transform.position.z);
                transform.Rotate(0, 0, 180);
                flipped = true;
            }
        }
        else
        {
            if (mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, mainCamera.pixelHeight)).y < -10.25f || mainCamera.ScreenToWorldPoint(new Vector3(mainCamera.pixelWidth / 2, 0)).y > 10.25f)
            {
                transform.position = new Vector3(-transform.position.x, transform.position.y - Mathf.Sign(transform.position.y) * bump_y, transform.position.z);
                transform.Rotate(0, 0, 180);
                flipped = false;
            }
        }
    }
}
