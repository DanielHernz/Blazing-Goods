using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropiedadProp : MonoBehaviour
{
    public string PropID;
    public int ValorProp;
    public Transform PosicionProp;
    // Start is called before the first frame update
    public PropiedadProp(string ID, int ValorProp)
    {
        this.PropID=ID;
        this.ValorProp=ValorProp;
    }
}
