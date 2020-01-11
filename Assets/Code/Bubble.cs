using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 3f;

    void Start()
    {
        Reset();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * _MoveSpeed);
        if (transform.position.y > 10)
        {
            Reset();
        }
    }

    private void Reset()
    {
        float randomHeight = Random.Range(-5f, -15f);
        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (OtherisFish(other))
        {
            ScoreKeeper scorekeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            scorekeeper.IncrementScore();
            Reset();
        }
    }

    bool OtherisFish(Collider2D other)
    {
        return (other.GetComponent<Fish>() != null);
    }
}
