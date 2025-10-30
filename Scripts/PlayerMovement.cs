using UnityEngine;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 50f; // hareket h�z�
    Rigidbody rb;//fizik componenti

    ScoreManager scoreManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();// scriptin ba�l� oldu�u nesne �zerindeki compenenti bul
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");//yatay hareket girdisi
        float moveZ = Input.GetAxis("Vertical");//dikey hareket girdisi

        Vector3 movement = new Vector3(moveX, 0f, moveZ);//Oyuncunun gitmek istedi�i y�n� belirle
        rb.AddForce(movement * moveSpeed);//Rigidbody gidilmek istenen y�nde kuvvet uygula b�ylece hareketi sa�lam�� oluruz
    }

    private void OnTriggerEnter(Collider other)
    {
        //E�er oyuncu 'Pickup' tag�na sahip bir nesneye �arparsa o nesneyi yok et.
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            scoreManager.CollectPickup();
        }
    }
}
