using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tema4 : MonoBehaviour
{
    
    public int flota;
    public int diasTotal;
    public int diasLluvia;

    // Start is called before the first frame update
    void Start()
    {
       
        if(diasTotal < 5)
        {
            Debug.Log("Error, la cantidad total de dias debe ser mayor a 5");
        }
        else if(diasLluvia < 0)
        {
            Debug.Log("Error, no podes ingresar un numero negativo");
        }
        else if(diasLluvia > diasTotal)
        {
            Debug.Log("Error, el numero de dias de lluvia no puede ser mayor a la cantidad total de dias");
        }
        else
        {
            int unidadKm = (diasTotal - diasLluvia) * 90;
            int unidadKmLluvia = diasLluvia * 120;

            int litrosXdia = 90 / 15;
            int litrosXlluvia = 120 / 15;

            int litrosUsados = (diasTotal - diasLluvia) * litrosXdia;
            int litrosUsadosLluvia = diasLluvia * litrosXlluvia;

            int litrosTotales = litrosUsados + litrosUsadosLluvia;

            int costoLitroUnidad = litrosTotales * 130;

            int costoLitrosTotales = costoLitroUnidad * flota;

            Debug.Log("Una flota de " + flota + " unidades trabajando durante " + diasTotal + " días implicará un gasto" +
            " de " + costoLitrosTotales + " pesos en concepto de combustible");
        }


       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
