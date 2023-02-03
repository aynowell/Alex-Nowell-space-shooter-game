using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{

	public GameObject enemyPrefab;
	public GameObject bossPrefab;

	float spawnDistance = 12f;

	float enemyRate = 5;
	float nextEnemy = 1;

	public int enemieskilled;
	bool bossspawned;
	public float money;
	public TMP_Text moneyText;

	private void Start()
	{
		money = PlayerPrefs.GetFloat("mula");
		moneyText.text = "$" + money.ToString();
	}

    public void updateMoney()
    {
		moneyText.text = "$" + money.ToString();
		PlayerPrefs.SetFloat("mula", money);
	}
    // Update is called once per frame
    void Update()
	{
		moneyText.text = "$" + money.ToString();
		if (bossspawned == true)
        {
			return;
        }
		nextEnemy -= Time.deltaTime;

		if (nextEnemy <= 0)
		{
			nextEnemy = enemyRate;
			enemyRate *= 0.10f;
			if (enemyRate < 3)
				enemyRate = 3;

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;
			if (enemieskilled == 5)
			{
				bossspawned = true;

				Instantiate(bossPrefab, transform.position + offset, Quaternion.identity);
			}
			else
			{
				Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
			}
		}
	}
}
