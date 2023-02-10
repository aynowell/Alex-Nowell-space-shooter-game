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



	public GameObject meteor;
	public GameObject force field;
	public GameObject minion;
	public GameObject bomb;
	public GameObject gun;
	public GameObject sonic boom;




	private void Start()
	{
		money = PlayerPrefs.GetFloat("mula");
		moneyText.text = "$" + money.ToString();

        if (PlayerPrefs.GetString("meteor") == "true")
        {
			PlayerPrefs.SetString("meteor", "false");

        }
		if (PlayerPrefs.GetString("force field") == "true")
		{
			PlayerPrefs.SetString("force field", "false");

		}
		if (PlayerPrefs.GetString("minion") == "true")
		{
			PlayerPrefs.SetString("minion", "false");

		}
		if (PlayerPrefs.GetString("bomb") == "true")
		{
			PlayerPrefs.SetString("bomb", "false");

		}
		if (PlayerPrefs.GetString("gun") == "true")
		{
			PlayerPrefs.SetString("gun", "false");

		}
		if (PlayerPrefs.GetString("sonic boom") == "true")
		{
			PlayerPrefs.SetString("sonic boom", "false");

		}
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
