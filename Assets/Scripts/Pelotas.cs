using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotas : MonoBehaviour {
    public bool Iniciar = false;
    public int x;
    public int y;
    public bool Limpiar = false;
    public bool checkout = false;
    public Material Negro;

    public int k;
    public GameObject[,] grid;
    public GameObject Rsphere;
    public GameObject Bsphere;
    public GameObject Gsphere;
    public GameObject Ysphere;
    
    void Start()
    {
       

    }

    void Update()
    {
    if (Iniciar == true)
        {

           
           Limpiar = true;
           if (Limpiar == true)
           {
                for(int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Destroy(grid[i, j]);
                    }
                }
                
            }
            Limpiar = false;

            x = Random.Range(3, 13);
            y = Random.Range(3, 13);
            grid = new GameObject[y, x];

            Debug.Log("hola");
            Creacion();
            Iniciar = false;
        }
    if (checkout == true)
        {
            Checar();
            
        }
    }
    public void Creacion()
    {
        GameObject Spheretemp;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                k = Random.Range(0, 4);
                if (k == 0)
                {
                     Spheretemp = Instantiate(Rsphere, new Vector3(i, j, 0), Quaternion.identity);
                }
                else if (k == 1)
                {
                     Spheretemp = Instantiate(Bsphere, new Vector3(i, j, 0), Quaternion.identity);
                }
                else if (k == 2)
                {
                     Spheretemp = Instantiate(Gsphere, new Vector3(i, j, 0), Quaternion.identity);
                }
                else 
                {
                     Spheretemp = Instantiate(Ysphere, new Vector3(i, j, 0), Quaternion.identity);
                }
                grid[i, j] = Spheretemp;
            }
        }
    }

    public void Checar()
    {
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (i + 1 < y)
                {
                    print(i);
                        if (grid[i, j].GetComponent<Renderer>().material.color == grid[i+1, j].GetComponent<Renderer>().material.color)
                        {
                            grid[i, j].GetComponent<Renderer>().material = Negro;
                            grid[i+1, j].GetComponent<Renderer>().material = Negro;
                        }
                }
            }
        }
    }
}


  

