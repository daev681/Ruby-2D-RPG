using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Vector2 position = transform.position;
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 12.0f * horizontal * Time.deltaTime;
        position.y = position.y + 12.0f * vertical * Time.deltaTime;
        //transform.position = position;
        rigidbody2d.MovePosition(position); //  Rigidbody를 원하는 위치로 이동하고, 이동 중 다른 콜라이더와 충돌하면 멈춘다.
    }

}