using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impresora : Boton
{
    public Transform NA,INT;
    private Transform Etiqueta, Player_Trans;
    private GameObject Player_GO;
    public Renderer Render_IMP;
    public Material Material_en_Turno,IMP_NA,IMP_INT;

    // Start is called before the first frame update
    void Start()
    {
        Player_GO = GameObject.FindGameObjectWithTag("Player");
        Player_Trans = Player_GO.transform;
        Render_IMP = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Material_en_Turno = Render_IMP.material;
        if (TriggerON == true)
        {
            //Material_en_Turno = Render_IMP.material;
            if (Material_en_Turno == IMP_NA)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Transform Instanciacion = Instantiate(NA,transform.position,Quaternion.identity);
                    Instanciacion.parent = transform;
                    Etiqueta = transform.GetChild(0);
                    Etiqueta.SetParent(Player_Trans);
                }
            }
            if (Material_en_Turno == IMP_INT)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Transform Instanciacion = Instantiate(INT,transform.position,Quaternion.identity);
                    Instanciacion.parent = transform;
                    Etiqueta = transform.GetChild(0);
                    Etiqueta.SetParent(Player_Trans);
                }
            }
        }
    }
}
