using Unity.VisualScripting;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    public int numeroEntero = 46;
    float numeroDecimales = 3.14f;
    public bool finPartida = false;
    string texto1 = "Has ganado";


    public int vidas = 3;

    void OnMouseDown(){
        vidas --;
        if (vidas == 0){
          Destroy(gameObject);  
        }
        
    }

    public GameObject destino;
    Vector3 posicionDestino;

    void Start(){
        posicionDestino = destino.transform.position;
    }

    void Update(){
        posicionDestino = destino.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, Time.deltaTime);

        // Rotacion
        transform.Rotate(Vector3.right * Time.deltaTime * 50);

    }

}

