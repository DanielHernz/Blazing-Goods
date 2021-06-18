using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProps : MonoBehaviour
{
    // Start is called before the first frame update
    public PropiedadProp[] NuevoProp;


    // Start is called before the first frame update
    void Awake()
    {
        NuevoProp=new PropiedadProp[10];
        NuevoProp[0]= new PropiedadProp("CajaG",30);
        NuevoProp[1]= new PropiedadProp("CajaM",20);
        NuevoProp[2]= new PropiedadProp("CajaC",10);
        NuevoProp[3]= new PropiedadProp("TecG",10);
        NuevoProp[4]= new PropiedadProp("TecM",8);
        NuevoProp[5]= new PropiedadProp("TecC",6);
        NuevoProp[6]= new PropiedadProp("EtiquetaNA",1);
        NuevoProp[7]= new PropiedadProp("EtiquetaINT",2);
        NuevoProp[8]= new PropiedadProp("Burbuja",4);
        NuevoProp[9]= new PropiedadProp("Envoltura",2);
    }
}
