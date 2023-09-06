using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    public NavMeshAgent navMeshAgent;
    public Transform player; // Referencia al transform del jugador
    public float detectionRange = 10f;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform; // Ajusta la etiqueta del jugador seg�n tu configuraci�n
    }

    private void Update()
    {
        // Calcula la distancia entre el enemigo y el jugador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < detectionRange)
        {
            //Debug.Log(player.position + "Player");
            // Mueve al enemigo hacia el jugador utilizando NavMesh
            navMeshAgent.destination = player.position;

            // El jugador est� dentro del rango de detecci�n, cambia a la animaci�n de Run
            //animator.SetBool("IsRunning", true);
            //Debug.Log("EnemyAnim");

        }
        else
        {
            // El jugador est� fuera del rango de detecci�n, cambia a la animaci�n de Idle
            //animator.SetBool("IsRunning", false);

            // Det�n al enemigo
            navMeshAgent.destination = this.transform.position;
        }
    }
}