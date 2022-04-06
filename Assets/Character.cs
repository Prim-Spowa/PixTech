using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character :  MonoBehaviour {

    public float speed = 20f;
    Rigidbody2D rb;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
    }
}