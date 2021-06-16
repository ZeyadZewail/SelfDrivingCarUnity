using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.AI;


public class MapManager : MonoBehaviour
{
    
    public Tilemap[] corners;
    public Tilemap[] T_shape;
    public Tilemap[] Crosses;
    public GameObject grid;

    public int rows;
    public int columns;
    void Start()
    {
        for (int i = 1;i <= rows; i++){
            for(int j = 1; j <= columns;j++){
                if(i == 1 && j == 1){
                    //bottom left corner
                    Tilemap tempW = Instantiate(corners[0]);
                    Tilemap tempO = Instantiate(corners[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    //flip on y
                    tempW.transform.localScale += (new Vector3(-2, 0, 0));
                    tempO.transform.localScale += (new Vector3(-2, 0, 0));
                    float temp1W = tempW.transform.localPosition.x + (21 * (j+1));
                    float temp2W = tempW.transform.localPosition.y + (21*i);
                    float temp1O = tempO.transform.localPosition.x + (21 * (j+1));
                    float temp2O = tempO.transform.localPosition.y + (21*i);
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);
                    
                    
                }else if(i == 1 &&  j == columns){
                    //bottom right corner
                    Tilemap tempW = Instantiate(corners[0]);
                    Tilemap tempO = Instantiate(corners[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    float temp1W = tempW.transform.localPosition.x + (21 * j);
                    float temp2W = tempW.transform.localPosition.y + (21 * i);
                    float temp1O = tempO.transform.localPosition.x + (21 * j);
                    float temp2O = tempO.transform.localPosition.y + (21 * i);
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);

                }else if(i == 1 && j < columns && j > 1){
                    //bottom T
                    Tilemap tempW = Instantiate(T_shape[0]);
                    Tilemap tempO = Instantiate(T_shape[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    tempW.transform.localScale += (new Vector3(0, -2, 0));
                    tempO.transform.localScale += (new Vector3(0, -2, 0));
                    float temp1W = tempW.transform.localPosition.x + (21 * (j));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i+1));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i+1));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);



                }else if(i >1 && i < rows && j == 1){
                    //left T
                    Tilemap tempW = Instantiate(T_shape[0]);
                    Tilemap tempO = Instantiate(T_shape[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    tempW.transform.Rotate(new Vector3(0, 0, 90));
                    tempO.transform.Rotate(new Vector3(0, 0, 90));
                    float temp1W = tempW.transform.localPosition.x + (21 * (j+1));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j+1));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);

                }else if(i == rows && j == columns){
                    //top right corner
                    Tilemap tempW = Instantiate(corners[2]);
                    Tilemap tempO = Instantiate(corners[3]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    float temp1W = tempW.transform.localPosition.x + (21 * j);
                    float temp2W = tempW.transform.localPosition.y + (21 * i);
                    float temp1O = tempO.transform.localPosition.x + (21 * j);
                    float temp2O = tempO.transform.localPosition.y + (21 * i);
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);
                }else if(i == rows && j == 1){
                    //top left corner
                    Tilemap tempW = Instantiate(corners[2]);
                    Tilemap tempO = Instantiate(corners[3]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    //flip on y
                    tempW.transform.localScale += (new Vector3(-2, 0, 0));
                    tempO.transform.localScale += (new Vector3(-2, 0, 0));
                    float temp1W = tempW.transform.localPosition.x + (21 * (j+1));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j+1));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);
                }else if(i == rows && j >1 && j < columns){
                    //bottom T
                    Tilemap tempW = Instantiate(T_shape[0]);
                    Tilemap tempO = Instantiate(T_shape[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    float temp1W = tempW.transform.localPosition.x + (21 * (j));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);

                }else if(i >1 && i < rows && j == columns){
                    //right T
                    Tilemap tempW = Instantiate(T_shape[0]);
                    Tilemap tempO = Instantiate(T_shape[1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    tempW.transform.Rotate(new Vector3(0, 0, -90));
                    tempO.transform.Rotate(new Vector3(0, 0, -90));
                    float temp1W = tempW.transform.localPosition.x + (21 * (j));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i+1));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i+1));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);


                }else{
                    int r = Random.Range(0, (Crosses.Length/2));
                    Tilemap tempW = Instantiate(Crosses[2*r]);
                    Tilemap tempO = Instantiate(Crosses[(2*r)+1]);
                    tempW.transform.SetParent(grid.transform);
                    tempO.transform.SetParent(grid.transform);
                    float temp1W = tempW.transform.localPosition.x + (21 * (j));
                    float temp2W = tempW.transform.localPosition.y + (21 * (i));
                    float temp1O = tempO.transform.localPosition.x + (21 * (j));
                    float temp2O = tempO.transform.localPosition.y + (21 * (i));
                    tempW.transform.position = new Vector3(temp1W, temp2W);
                    tempO.transform.position = new Vector3(temp1O, temp2O);




                }

                





            }
        }

        this.GetComponent<NavMeshSurface2d>().BuildNavMesh();


        //for(int i =0; i < 4 ; i++){
         //   for(int j = 0; j<4;j++){
          //      int max = 8;
            //    int r = Random.Range(0, max);
           //     if (r % 2 != 0)
            //        r += 1;
            //    Tilemap tempW = Instantiate(tilemaps[r]);
            //    Tilemap tempO = Instantiate(tilemaps[r+1]);
            //    tempW.transform.SetParent(grid.transform);
            //    tempO.transform.SetParent(grid.transform);
             //   float temp1W = tempW.transform.localPosition.x + (21 * i);
             //   float temp2W = tempW.transform.localPosition.y + (21 * j);
             //   float temp1O = tempO.transform.localPosition.x + (21 * i);
             //   float temp2O = tempO.transform.localPosition.y + (21 * j);
            //    tempW.transform.position = new Vector3(temp1W, temp2W);
            //    tempO.transform.position = new Vector3(temp1O, temp2O);
           // }


        //}








        





    }

    // Update is called once per frame
    void Update()
    {

   
    }
}
