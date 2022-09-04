using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform SpawnArea;
    public int spawnInterval;
    public int maxPowerUpAmount;
    public Vector2 PowerUpAreaMin;
    public Vector2 PowerUpAreaMax;
    private List<GameObject> PowerUpTemplateList;
    private List<GameObject> PowerUpList;

    private float timer;

    private void Start()
    {
        PowerUpList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer = Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(PowerUpAreaMin.x, PowerUpAreaMax.x), Random.Range(PowerUpAreaMin.y, PowerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (PowerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }
        if (position.x < PowerUpAreaMin.x || 
            position.x > PowerUpAreaMax.x || 
            position.y < PowerUpAreaMin.y || 
            position.y > PowerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, PowerUpTemplateList.Count);

        GameObject PowerUp = Instantiate(PowerUpTemplateList[randomIndex], new Vector3(position.x, position.y, PowerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, SpawnArea);
        PowerUp.SetActive(true);
        
        PowerUpList.Add(PowerUp);
    }

    public void RemovePowerUp(GameObject PowerUp)
    {
        PowerUpList.Remove(PowerUp);
        Destroy(PowerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (PowerUpList.Count > 0)
        {
            RemovePowerUp(PowerUpList[0]);
        }
    }
}
