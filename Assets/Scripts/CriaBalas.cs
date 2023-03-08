using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaBalas : MonoBehaviour
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private GameObject Cannon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shooter();
    }

    void Shooter()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(objeto, posição, rotação);
            Instantiate(shoot, new Vector3(Cannon.transform.position.x, Cannon.transform.position.y, Cannon.transform.position.z), Cannon.transform.rotation);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Metroid"))
        {
            Destroy(gameObject);
        }
    }
}
