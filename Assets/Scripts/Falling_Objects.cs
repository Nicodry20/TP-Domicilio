using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Falling_Objects : MonoBehaviour
{
    public GameObject[] objectSpawn; 
    public float minX = -3.5f;
    public float maxX = 3.5f;
    public float spawnY = 4f; 
    public float spawnZ = -2.5f;

    public InputField inputField;
    public Button responderButton;
    public GameObject panelNotificaciones;
    public Text notificacionTexto;
    public GameObject panelDebeIngresarResultado;
    public Button cerrarPanelDebeIngresarResultado;

    private int cantidadObjetos;

    void Start()
    {
        responderButton.onClick.AddListener(VerificarRespuesta);
        cerrarPanelDebeIngresarResultado.onClick.AddListener(CerrarPanelDebeIngresarResultado);

        SpawnObjects();
    }

    void SpawnObjects()
    {
        cantidadObjetos = 0;
        foreach (GameObject obj in objectSpawn)
        {
            int num = Random.Range(0, 2);
            for (int i = 0; i < num; i++)
            {
                float randomX = Random.Range(minX, maxX);
                Vector3 newPosition = new Vector3(randomX, spawnY, spawnZ);
                Instantiate(obj, newPosition, Quaternion.identity);
                cantidadObjetos++;
            }
        }
    }

    void VerificarRespuesta()
    {
        string respuesta = inputField.text;

        if (string.IsNullOrEmpty(respuesta))
        {
            panelDebeIngresarResultado.SetActive(true);
        }
        else
        {
            int cantidadIngresada = int.Parse(respuesta);
            if (cantidadIngresada == cantidadObjetos)
            {
                notificacionTexto.text = "¡Correcto!";
            }
            else
            {
                notificacionTexto.text = "Incorrecto. Inténtalo de nuevo.";
            }

            panelNotificaciones.SetActive(true);
        }
    }

    void CerrarPanelDebeIngresarResultado()
    {
        panelDebeIngresarResultado.SetActive(false);
    }
}
    
