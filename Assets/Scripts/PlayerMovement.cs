using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMove; //Kecepatan Gerak Pemain
    public string horAxis; //Input controller untuk kanan dan kiri
    public string verAxis; //Input controller untuk atas dan bawah
    public string buttonGive; //Tombol untuk memberi barang
    private Rigidbody2D rb; //Komponen rigidbody2D yang digunakan
    private Vector2 moveVelocity; //Penggunaan vector2
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + moveVelocity*Time.deltaTime);    
    }

    //Untuk pemain berjalan menggunakan axis
    public void Move()
    {
        Vector2 moveDirection = new Vector2(Input.GetAxisRaw(horAxis), Input.GetAxisRaw(verAxis));
        moveVelocity = moveDirection.normalized*speedMove;
    }
}

