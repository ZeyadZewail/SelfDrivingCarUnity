using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.AI;


public class MapManager : MonoBehaviour
{
    
    public Tilemap[] tilemaps;
    public GameObject grid;


    void Start()
    {
        //Tilemap tempW = Instantiate(tilemaps[0]);
        //Tilemap tempO = Instantiate(tilemaps[1]);
        //tempW.transform.SetParent(grid.transform);
        //tempO.transform.SetParent(grid.transform);
        //Tilemap tempW1 = Instantiate(tilemaps[0]);
        //Tilemap tempO1 = Instantiate(tilemaps[1]);
        //tempW1.transform.SetParent(grid.transform);
        //tempO1.transform.SetParent(grid.transform);
        //tempW1.transform.position = new Vector3(tempW1.transform.position.x +21,tempW1.transform.position.y);
        //tempO1.transform.position = new Vector3(tempO1.transform.position.x +21,tempW1.transform.position.y);


        for(int i =0; i < 4 ; i++){
            for(int j = 0; j<4;j++){
                int max = 8;
                int r = Random.Range(0, max);
                if (r % 2 != 0)
                    r += 1;
                Tilemap tempW = Instantiate(tilemaps[r]);
                Tilemap tempO = Instantiate(tilemaps[r+1]);
                tempW.transform.SetParent(grid.transform);
                tempO.transform.SetParent(grid.transform);
                float temp1W = tempW.transform.localPosition.x + (21 * i);
                float temp2W = tempW.transform.localPosition.y + (21 * j);
                float temp1O = tempO.transform.localPosition.x + (21 * i);
                float temp2O = tempO.transform.localPosition.y + (21 * j);
                tempW.transform.position = new Vector3(temp1W, temp2W);
                tempO.transform.position = new Vector3(temp1O, temp2O);


            }


        }








        this.GetComponent<NavMeshSurface2d>().BuildNavMesh();





    }

    // Update is called once per frame
    void Update()
    {

   
    }
}
