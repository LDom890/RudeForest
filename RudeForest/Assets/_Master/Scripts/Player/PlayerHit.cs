using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    // Este método se llama cuando algo entra en el trigger del enemigo.
    private void OnTriggerEnter(Collider other)
    {
        // Comprobamos si el objeto que entró en el trigger es el jugador.
        if (other.CompareTag("Player"))
        {
            // Aquí puedes agregar cualquier lógica adicional que desees antes de apagar al enemigo.

            // Accedemos al GameObject padre y lo desactivamos para "apagarlo".
            Transform parentTransform = transform.parent;
            if (parentTransform != null)
            {
                parentTransform.gameObject.SetActive(false);
            }
        }
    }
}