using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public GameObject enterDoor;
    public GameObject player;
    public GameObject endPopUp;

    public float timeDelay;
    public int StageCount = 0;

    
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    private void Start()
    {
        PlayerPrefeb();
        EnemyPrefeb();
    }
    private void Update()
    {
        ReSpawnObject();
    }

    private void ReSpawnObject()
    {
        if (StageCount > 3)
        {
            endPopUp.SetActive(true);
        }
        if (player.transform.GetChild(0).GetComponent<CharacterAction>().nextToStage == true)
        {
            StageCount++;
            if (StageCount <= 2)
            {
                EnemyPrefeb();
                player.transform.GetChild(0).position = new Vector2(-7.5f, 0);
                player.transform.GetChild(0).GetComponent<CharacterAction>().enemyKillCount = 0;
                player.transform.GetChild(0).GetComponent<CharacterAction>().nextToStage = false;
            }
            
        }
    }
    #region Instantiate
    private void PlayerPrefeb()
    {
        player = Instantiate(playerPrefab);

    }
    private void EnemyPrefeb()
    {
        for (int i = 0; i < 5; i++) // 5마리의 적을 생성
        {
            // 랜덤 위치 생성
            float randomX = UnityEngine.Random.Range(-2f, 7f);
            float randomY = UnityEngine.Random.Range(-3f, 3f);
            Vector2 randomPosition = new Vector2(randomX, randomY);

            // 적 생성
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
    }

    #endregion

    public void PlayerTranform(GameObject _player) // 플레이어 위치 값을 위한 것
    {
        playerPrefab = _player;
    }
    
}
