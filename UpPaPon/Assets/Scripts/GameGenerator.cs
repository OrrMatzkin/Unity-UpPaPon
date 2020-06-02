using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class GameGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject MainPlayer, Player;


    private int amountToSpawn = 6; // Including the main player 

    private double playerHeight = 0.8f, playerDiameter = 1f; // Y = height, X and Z = Diameter
    private double radiusOfPlayersCircle = 5f;

    private List<double> allX = new List<double>();
    private List<double> allY = new List<double>();


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
        // List <double> degrees = new List<double>();
        // float degreeBetweenPlayer = 360/amountToSpawn;

        // for (int i=0; i < amountToSpawn; i++){
        //     if(i==0){
        //         degrees.Add(270);
        //     } else {
        //         degrees.Add(270 - degreeBetweenPlayer * i);
        //     }
        // }

        // for (int i=0; i < amountToSpawn; i++){
        //     allX.Add(Math.Round(Math.Cos((Math.PI / 180) * degrees[i]), 3));
        //     allY.Add(Math.Round(Math.Sin((Math.PI / 180) * degrees[i]), 3));
        // }
    }

    void InstantiateLevel()
    {
        // for (int i = 0; i < amountToSpawn; i++){    
        //     GameObject newPlayer;

        //     if (i==0){
        //         newPlayer = Instantiate(MainPlayer);
        //         newPlayer.tag = "MainPlayer";
        //     } else {
        //         newPlayer = Instantiate(newPlayer);
        //     }
            
            // newPlayer.transform.X = allX[i];
            // newPlayer.transform.Z = allY[i];
            // newPlayer.transform.Y = 0;
        //     spawnedPlayers.Add(newPlayer);

        //     if (i==0){
        //         lastPos = newPlatform.transform.position;
        //         Vector3 temp = lastPos;
        //         temp.y += 0.1f;
        //         Instantiate(playerPrefab, temp, Quaternion.identity);
        //         continue;
        //     }

           

        //     lastPos = newPlatform.transform.position;

        //     //fancy animation
            
        //     if (i<25){
        //         float endPos = newPlatform.transform.position.y;
        //         newPlatform.transform.position = new Vector3(newPlatform.transform.position.x, newPlatform.transform.position.y - blockHeight*3f, newPlatform.transform.position.z);
        //         newPlatform.transform.DOLocalMoveY(endPos, 0.3f).SetDelay(i*0.1f);
        //     }


        // }
    }
}
