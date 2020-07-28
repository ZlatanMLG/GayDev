using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5; 
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        if (moveX != 0)
        {
            position.x += moveX * moveSpeed * Time.deltaTime;
        }
        if (moveY != 0)
        {
            position.y += moveY * moveSpeed * Time.deltaTime;
        }
        transform.position = position;
    }
}
