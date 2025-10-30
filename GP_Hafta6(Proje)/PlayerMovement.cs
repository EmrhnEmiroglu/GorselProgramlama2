using UnityEngine;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket hýzý
    Rigidbody rb;//fizik componenti

    ScoreManager scoreManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();// scriptin baðlý olduðu nesne üzerindeki compenenti bul
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");//yatay hareket girdisi
        float moveZ = Input.GetAxis("Vertical");//dikey hareket girdisi

        Vector3 movement = new Vector3(moveX, 0f, moveZ);//Oyuncunun gitmek istediði yönü belirle
        rb.AddForce(movement * moveSpeed);//Rigidbody gidilmek istenen yönde kuvvet uygula böylece hareketi saðlamýþ oluruz
    }

    private void OnTriggerEnter(Collider other)
    {
        //Eðer oyuncu 'Pickup' tagýna sahip bir nesneye çarparsa o nesneyi yok et.
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            scoreManager.CollectPickup();
        }
    }
}
