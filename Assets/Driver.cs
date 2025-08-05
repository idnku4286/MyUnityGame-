using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float fastSpeed = 30f;
    void Start()
    {
        
    }


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed*Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed* Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
     
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("�浹�߽��ϴ�.");
            moveSpeed = slowSpeed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boost")
        {
            Debug.Log("�ν��͸� �޾ҽ��ϴ�.");
            moveSpeed = fastSpeed;
        }
    }
}
