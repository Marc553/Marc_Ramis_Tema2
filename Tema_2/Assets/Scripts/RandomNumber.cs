using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{

    public int randNum;
    private int myNum;
    private int counter; //Numero de intentos


    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            counter++;//counter == counter + 1, counter += 1
        }

    }

    public void CompareToRandomNumber(int userNum)
    {
        if (userNum > randNum)
        {
            Debug.Log($"Casi, {myNum} es mayor al que he pensado.");
        }

        if (userNum < randNum)
        {
            Debug.Log($"Vaya, {myNum} es menor al que he pensado.");
        }

        if (userNum == randNum)
        {
            Debug.Log($"Enhorabuena has acetado, el numero era {myNum}");
            Debug.Log($"Has utilizado {counter} intentos");
        }
    }
    
}
