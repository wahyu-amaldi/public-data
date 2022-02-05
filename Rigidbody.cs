using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronotMovement : MonoBehaviour
{
    /*
        Komponen 2D Rigidbody menempatkan objek di bawah kendali mesin fisika
.       Banyak konsep yang familiar dari Rigidbody standar
        komponen terbawa ke Rigidbody 2D; perbedaannya adalah pada 2D, 
        benda hanya dapat bergerak pada bidang XY dan hanya dapat berputar pada sumbu yang tegak lurus terhadap bidang tersebut.
     */
    Rigidbody2D Rb;
    public float data_movement;
    public float data_jumping;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*
            Developer Game : Wahyu Amaldi, M.Kom
            Input.GetAxisRaw : GetAxisRaw akan mengembalikan nilai sumbu virtual yang diidentifikasi oleh axisName.
            Untuk nilainya juga sama, akan berada di kisaran -1 … 1 untuk input keyboard dan juga joystick.
            Akan tetapi, karena input pada GetAxisRaw ini tidak smoothed (dihaluskan), input pada keyboard akan selalu berada pada nilai -1, 0 dan 1.
         */
        float horiz = Input.GetAxisRaw("Horizontal"); // -1 (Kekiri) / 1 (Kekanan)
        Rb.velocity = new Vector2(data_movement * horiz, Rb.velocity.y); //velocity :  Ini mewakili tingkat perubahan posisi Rigidbody.
        if (Input.GetButtonDown("Jump")) 
        {
            Rb.AddForce(new Vector2(0, data_jumping));
        }
    }
}
