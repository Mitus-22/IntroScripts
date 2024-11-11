
using UnityEngine;

using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    int contador = 0;

    public GameObject itemFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moverse
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * Time.deltaTime * 10);
        }

        // Salir del juego
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }

    }
    // Eliminar objetos al tocarlos
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Item") {
            Destroy(other.gameObject);
            contador++;
            if (contador == 10) {
                itemFinal.SetActive(true);
            }
        }

        if (other.gameObject.tag == "Finish") {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");

        }

    
    }



}
