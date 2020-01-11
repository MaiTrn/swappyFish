using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 5f;
    [SerializeField]
    private bool _Obstacle = true;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _MoveSpeed);
        if (transform.position.x < -15)
        {
            if (_Obstacle)
            {
                float ranY = UnityEngine.Random.Range(-3, 3);
                transform.position = new Vector3(15, ranY, 0);
            }
            else
            {
                transform.position = new Vector3(15, transform.position.y, -1);
            }
        }
    }
}
