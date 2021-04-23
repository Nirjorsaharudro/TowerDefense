﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
  public Transform enemyPrefab;

  public Transform spawnPoint;

  public float timeBetweenWaves = 5f;
  private float countdown = 2f;

  public Text waveCountdownText;
  
  private int WaveIndex = 0;
  void Update(){
      if (countdown <= 0f)
      {
        StartCoroutine(SpawnWave());
        countdown = timeBetweenWaves;
      }
      countdown -= Time.deltaTime;
      
      countdown = Mathf.Clamp(countdown,0f,Mathf.Infinity);
      waveCountdownText.text = string.Format("{0:00.00}",countdown);
  }

  IEnumerator SpawnWave(){
      WaveIndex++;
      PlayerStats.Rounds++;

      for (int i = 0; i < WaveIndex; i++)
      {
         SpawnEnemy(); 
         yield return new WaitForSeconds(0.5f);
      }
  }

  void SpawnEnemy(){
      Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);
  }
}
