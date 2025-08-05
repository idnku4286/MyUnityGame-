using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{
    [SerializeField] Color32 hasPakageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 NonePackageColor = new Color32(1,1,1,1);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer SpriteRenderer;
    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("충돌했습니다.");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            SpriteRenderer.color = hasPakageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Customer"&& hasPackage) 
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            SpriteRenderer.color = NonePackageColor;
        }
    }
}

