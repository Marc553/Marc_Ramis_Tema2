using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProject : MonoBehaviour
{/*
    
    private float playerSpeed = 5.25f;
    public string playerName = "Marc";
    [SerializeField] private bool gameOver;
    
    public int x = 5;
    public int y = 5;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;
    // Start is called before the first frame update*/
    public int playerAge = 35;

    void Start()
    {/*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log("Multiplicacion: " + x + " * " + y + " = " + (x * y));
        Debug.Log("Division: " + x + " / " + y + " = " + (x / y));
        Debug.Log("Division: " + x + " / " + y + " = " + (a / b));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        
        if (isRaining == true)
        {
            Debug.Log("Lleva paraguas.");
        }
        else
        {
            Debug.Log("No llueve, no lleves paraguas.");
        }
*/
         if(playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad.");
        }
         else if (playerAge <= 13)
        {
            Debug.Log("Eres adolescente.");
        }
         else
        {
            Debug.Log("Eres un niño.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
