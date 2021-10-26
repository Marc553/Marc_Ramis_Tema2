using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstProject : MonoBehaviour
{/*
    
    private float playerSpeeddd = 5.25f;
    public string playerName = "Marc";
    [SerializeField] private bool gameOver;
   
    public int x = 5;
    public int y = 2;
/*public int playerAge = 35;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;
    // Start is called before the first frame update
    public bool isCold; */

    //public Vector3 myPosition;

    // public string hello;

    public int number1;
    public int number2;


    void Start()
    {
        Debug.Log(operation(number1,number2));
        

        //Como llamar a una función 
        /* HelloWorld();
         /*hello = GetHello();
         Debug.Log(hello); 

         Debug.Log(GetHello());*/

        /*
        myPosition = new Vector3(0,8,0);
        transform.position = myPosition;
        Debug.Log(transform.position);


        if (isRaining == true)
        {
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera.");
            }
            else

            {
                Debug.Log("Lleva paraguas.");
            }
      
        }
        else
        {
           if (isCold == true)
            {
                Debug.Log("Lleva una sudadera.");
            }
              else
            {
                Debug.Log("Disfruta el día.");
            }
       
                
             
        }
    
    /*
        if (x == 2 || y <= 5)
        {
            Debug.Log("VERDADERO");
        }else
        {
            Debug.Log("FALSOOO");
        }
        
        
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log("Multiplicacion: " + x + " * " + y + " = " + (x * y));
        Debug.Log("Division: " + x + " / " + y + " = " + (x / y));
        Debug.Log("Division: " + x + " / " + y + " = " + (a / b));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        
     
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
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        //Como mostrar una transformación
        // Debug.Log(transform.position);

        //orden de como se ejecuta una acción a un boton
        /*if(Input.GetKey(KeyCode.D))
         {
             transform.position += Vector3.right;
         }

         if (Input.GetKeyDown(KeyCode.A))
         {
             transform.position += Vector3.left;
         }

         if (Input.GetKeyDown(KeyCode.W))
         {
             transform.position += Vector3.up;
         }

         if (Input.GetKeyDown(KeyCode.S))
         {
             transform.position += Vector3.down;
         }

         if(Input.GetKeyDown(KeyCode.RightArrow))
         {
             transform.rotation *= Quaternion.Euler(0, 10, 0);
         }

         if (Input.GetKeyDown(KeyCode.LeftArrow))
         {
             transform.rotation *= Quaternion.Euler(0,-10, 0);
         }

         if (Input.GetKeyDown(KeyCode.UpArrow))
         {
             transform.rotation *= Quaternion.Euler(10, 0, 0);
         }

         if (Input.GetKeyDown(KeyCode.DownArrow))
         {
             transform.rotation *= Quaternion.Euler(-14, 0, 0);
         }

         if(Input.GetKeyDown(KeyCode.R))
         {
             transform.localScale += Vector3.right;
         }*/
        //Llamado de la función de movimiento 
        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.S, Vector3.back);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.Q, Vector3.up);
        MovementToDirection(KeyCode.E, Vector3.down);

        //Llamado de la función de escaldo en eje x
        MovementToScale(KeyCode.X, Vector3.right);
        MovementToScale(KeyCode.V, Vector3.left);

        //Llamado de la función de escalado en el eje z
        MovementToScale(KeyCode.Z, Vector3.forward);
        MovementToScale(KeyCode.B, Vector3.back);

        //Llamado de la función de escaldo en el eje y
        MovementToScale(KeyCode.Y, Vector3.up);
        MovementToScale(KeyCode.U, Vector3.down);

        //Llamado de la función de rotación en el eje x
        MovementToRotation(KeyCode.UpArrow, new Vector3(0, 0, 10));



    }

    //Como se hace una función sin respuesta
    /* public void HelloWorld()
     {
         Debug.Log("¡Hola, Mundo!");
     }
    //Función con un string
     public string GetHello()
     {
         return "Hello";

     }*/

    //Función del movimineto 
    public void MovementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direction;

        }
    }
    //Función de escalado 
    public void MovementToScale(KeyCode key, Vector3 sacale)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += sacale;
        }

    }
    //Función de rotación
    public void MovementToRotation(KeyCode key, Vector3 rotation)

    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }

    }

    //Función que calcula
    public int operation(int x, int y)
    {
        int result = x * y;
        Debug.Log($"{x} * {y} = {result}");
        return result; 
    }


}
