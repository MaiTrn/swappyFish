using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField]
    private float _upwardForceMultiplier = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool pFireButton = Input.GetButtonDown("Fire1");
        if (pFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);
            if (transform.position.y < -6f || transform.position.y > 6f)
            {
                Application.LoadLevel(0);
            }
        }
    }
}
