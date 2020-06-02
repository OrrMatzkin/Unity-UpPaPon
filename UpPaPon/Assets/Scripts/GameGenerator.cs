using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class GameGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject MainPlayer, Player;

    [SerializeField]
    private int amountToSpawn = 12; // Including the main player 

    private double playerHeight = 0.8f, playerDiameter = 1f; // Y = height, X and Z = Diameter
    private double radiusOfPlayersCircle = 5f;

    private List<float> allX = new List<float>();
    private List<float> allY = new List<float>();


    private List<GameObject> spawnedPlayers = new List<GameObject>();

    void Awake()
    {
        CalculateXY();
        InstantiateLevel();  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculateXY()
    {
        List <double> degrees = new List<double>();
        float degreeBetweenPlayer = 360/amountToSpawn;

        for (int i=0; i < amountToSpawn; i++){
            if(i==0){
                degrees.Add(270);
            } else {
                degrees.Add(270 - degreeBetweenPlayer * i);
            }
        }

        for (int i=0; i < amountToSpawn; i++){
            double xx = Math.Round(radiusOfPlayersCircle * Math.Cos((Math.PI / 180) * degrees[i]), 3);
            double yy = Math.Round(radiusOfPlayersCircle * Math.Sin((Math.PI / 180) * degrees[i]), 3);

            float x = Convert.ToSingle(xx);
            float y = Convert.ToSingle(yy);

            allX.Add(x);
            allY.Add(y);
            Debug.Log(allX[i]);
            Debug.Log(allY[i]);
        }
       
    }

    void InstantiateLevel()
    {
        for (int i = 0; i < amountToSpawn; i++){    
            GameObject newPlayer;

            if (i==0){
                newPlayer = Instantiate(MainPlayer);
                newPlayer.tag = "MainPlayer";
            } else {
                newPlayer = Instantiate(Player);
            }

            newPlayer.transform.position = new Vector3(allX[i], 0, allY[i]);
            
            
            spawnedPlayers.Add(newPlayer);

            // if (i==0){
            //     lastPos = newPlatform.transform.position;
            //     Vector3 temp = lastPos;
            //     temp.y += 0.1f;
            //     Instantiate(playerPrefab, temp, Quaternion.identity);
            //     continue;
            // }

           

            // lastPos = newPlatform.transform.position;

            //fancy animation
            
            if (i<25){
                float endPos = newPlayer.transform.position.y;
                newPlayer.transform.position = new Vector3(allX[i], -20, allY[i]);
                newPlayer.transform.DOLocalMoveY(endPos, 0.3f).SetDelay(i*0.2f);
            }


        }
    }
}
