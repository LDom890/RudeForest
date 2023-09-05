using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 7f;
    public float rotationSpeed = 250f;
    public float jumpForce = 10f;
    private Rigidbody rb;
    private bool enSuelo = true;

    public Animator animator;
    private float x, y, z;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        z = Input.GetAxis("Jump");
        if (enSuelo)
        {
            // Detecta la entrada del salto (por ejemplo, el botón "Espacio").
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Aplica una fuerza hacia arriba para simular el salto.
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                enSuelo = false; // El personaje ya no está en el suelo.
            }
        }
       
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);
        transform.Translate(0, z * Time.deltaTime * jumpForce, 0);

        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);
        //animator.SetFloat("VelZ", z);    Terminar de añadir la animacion al Blendeo

    }
}
