using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotPotato : MonoBehaviour
{
    private int counter;
    public Color colorMat;

    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = colorMat;
        colorMat = new Color();
    }
    private void OnMouseDown()
    {
        transform.localScale += 2 * Vector3.one;
        counter--;
        
        if(counter == 0)
        {
            Destroy(gameObject);
        }
    }



}
