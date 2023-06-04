using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float rotation_speed;
    [SerializeField] public float min_speed;
    [SerializeField] public GameObject Plane;

    private Rigidbody Rigidbody;
    private Animation Animation;
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Animation = Plane.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.velocity = -Plane.transform.right * (Input.GetAxis("Vertical") + 1 + min_speed) * speed;
        Plane.transform.Rotate(0, Input.GetAxis("Horizontal") * rotation_speed, 0);
    }
}