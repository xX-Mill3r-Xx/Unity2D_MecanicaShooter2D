using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBalas : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));
    }
}
