using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject Impresora_G_O;
    protected Transform Impresora_Trans;
    public Material Amarillo_NA , Morado_INT;
    private int Cambio_Material;
    protected bool TriggerON;
    private bool Amarillo = true;
    protected bool Case01_ON;

    private Renderer Cambio_Color_Imp, Cambio_Color_Boton;

    

    // Start is called before the first frame update
    void Start()
    {
        Cambio_Color_Imp = Impresora_G_O.GetComponent<Renderer>();
        Impresora_Trans = GetComponent<Transform>();
        Cambio_Color_Boton = GetComponent<Renderer>();
        Case01_ON = false;
    }

    //IEnumerator Esperar(){yield return new WaitForSecondsRealtime(2);}

    private void OnTriggerEnter(Collider collider) 
    {
        TriggerON = true;
        Debug.Log("TriggerON ="+ TriggerON);
    }
    private void OnTriggerExit(Collider collider) 
    {
        TriggerON = false;
        Debug.Log("TriggerON ="+ TriggerON);
    }

    // Update is called once per frame
    void Update()
    {
        //Renderer Cambio_Color_Imp = Impresora_G_O.GetComponent<Renderer>();
        //Renderer Cambio_Color_Boton = GetComponent<Renderer>();

        if (TriggerON == true)
        {
            if (Amarillo == true)
            {
                if (Input.GetMouseButtonDown(0)) {Cambio_Material = 1; 
                Amarillo = false;}  
            } 
            else
            {
                if (Input.GetMouseButtonDown(0)) {Cambio_Material = 2; Amarillo = true;}  
            }
            switch (Cambio_Material)
            {
                case 1:
                Case01_ON = true;
                Debug.Log("1");
                Cambio_Color_Imp.material = Amarillo_NA; 
                Cambio_Color_Boton.material = Morado_INT;
                break;

                case 2: 
                Case01_ON = false;
                Cambio_Color_Imp.material = Morado_INT; 
                Cambio_Color_Boton.material = Amarillo_NA; 
                break;
                
                default:
                break;
            }
        }
    }
}
