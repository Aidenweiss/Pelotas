using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelotas : MonoBehaviour {
    public bool Iniciar = false;
    public int x;
    public int y;
    
    public int k;
    public GameObject[,] grid;
    public GameObject Rsphere;
    public GameObject Bsphere;
    public GameObject Gsphere;
    public GameObject Ysphere;
    
    void Start()
    {
        x = Random.Range(3, 13);
        y = Random.Range(3, 13);
        grid = new GameObject[y,x];

        }

    void Update()
    {
    if (Iniciar == true)
        {
           Debug.Log("hola");
           Creacion();
            Iniciar = false;
        }
          
    }
    public void Creacion()
    {
       
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    k = Random.Range(0, 3);
                    if (k == 0)
                    {
                        GameObject Spheretemp = Instantiate(Rsphere, new Vector3(i, j, 0), Quaternion.identity);
                    }
                    else if (k == 1)
                    {
                        GameObject Spheretemp = Instantiate(Bsphere, new Vector3(i, j, 0), Quaternion.identity);
                    }
                    else if (k == 1)
                    {
                        GameObject Spheretemp = Instantiate(Gsphere, new Vector3(i, j, 0), Quaternion.identity);
                    }
                    else if (k == 1)
                    {
                        GameObject Spheretemp = Instantiate(Ysphere, new Vector3(i, j, 0), Quaternion.identity);
                    }
                }
            }
    }
    
    }


  

