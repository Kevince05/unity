using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float rotation_speed;
    [SerializeField]
    public GameObject Plane;

    private Rigidbody Rigidbody;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.velocity = -Plane.transform.right * Input.GetAxis("Vertical");
        Plane.transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotation_speed, 0));
    }
}