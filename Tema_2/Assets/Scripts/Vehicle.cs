using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que gurda el sonido del vehiculo.
    [SerializeField] private string sound = "!BRUM BRUM!";
    [SerializeField] private string name = "Coche";
    [SerializeField] private int numberWheels = 4;
    //La variable name guarda el nombre del vehiculo y la variable numberWheels guarda el numero de ruedas del vehiculo.
    [SerializeField] private bool hasSirena;
    //Comprueba si tiene sirena.
    [SerializeField] private bool isOn = true;
    //Comprueba si esta en marcha
    [SerializeField] private float gasoline;
    //Cantidad de gasolina

    // Start is called before the first frame update
    void Start()
    {/*
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");
        if (hasSirena) //Cuando sea true dira que ambulancia tiene sirena
        {
            Debug.Log($"{name} tiene sirena.");
        }
        else
        {
            Debug.Log($"{name} no tiene sirena.");
        }
        if (isOn)
        {
            Debug.Log(sound);
        }
        else if (hasSirena)
        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no está en marcha.");

        }*/

        if (gasoline < 10 && isOn == true)
        {
            Debug.Log($"¡A {name} le queda poca gasolina!");

            if (hasSirena)
            {
                Debug.Log(sound);
            }
            else
            {
                Debug.Log($"{name} no tiene sirena.");
            }
        }else
        {
            Debug.Log($"{name} no esta en marcha.");
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
