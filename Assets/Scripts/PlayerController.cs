using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Update()
    {
        Move();
    }

    public void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") *speed* Time.deltaTime; 
        var x = Mathf.Clamp(transform.position.x + deltaX, -5, 5);
        

        var deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        var y = Mathf.Clamp(transform.position.y + deltaY, -9, 0);
        transform.position = new Vector2(x, y);


    }
}
