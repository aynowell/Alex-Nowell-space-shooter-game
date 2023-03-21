using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
	public AudioClip NormalMusic;
	public AudioClip BossMusic;
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
	public GameObject forcefield;
	public GameObject minion;
	public GameObject bomb;
	//public GameObject gun;
	public GameObject sonicboom;
	public GameObject crosshair;



	private void Start()
	{
		money = PlayerPrefs.GetFloat("mula");
		moneyText.text = "$" + money.ToString();
	}
	public void enableGun()
	{
		if (PlayerPrefs.GetString("gun") == "true")
		{
			crosshair.SetActive(true);
			GameObject.FindGameObjectWithTag("Player").GetComponent<shooting>().specialshooting = true;
			PlayerPrefs.SetString("gun", "false");

		}  
	}
	public void enableMeteor()
	{
		if (PlayerPrefs.GetString("meteor") == "true")
		{
			PlayerPrefs.SetString("meteor", "false");
			GameObject clone = Instantiate(meteor, new Vector3(-13.5f, 18.5f, 0), Quaternion.identity);
			Destroy(clone, 12);

		}
	}
	public void enablebomb()
	{
		if (PlayerPrefs.GetString("bomb") == "true")
		{
			GameObject clone = Instantiate(bomb);
			PlayerPrefs.SetString("bomb", "false");

		}
	}
	public void enableSonicboom()
	{
		if (PlayerPrefs.GetString("sonic boom") == "true")
		{

			GameObject clone = Instantiate(sonicboom);
			Transform player = GameObject.FindGameObjectWithTag("Player").transform;
			clone.transform.SetParent(player);
			clone.transform.localPosition = Vector3.zero;
			clone.transform.SetParent(null);
			PlayerPrefs.SetString("sonic boom", "false");

		}
	}
	public void enableMinions()
	{
		if (PlayerPrefs.GetString("minion") == "true")
		{
			PlayerPrefs.SetString("minion", "false");
			GameObject minionClone = Instantiate(minion);
			Transform player = GameObject.FindGameObjectWithTag("Player").transform;
			minionClone.transform.SetParent(player);
			minionClone.transform.localEulerAngles = Vector3.zero;
			minionClone.transform.localPosition = new Vector3(0.78f, -0.14f, 0);

		}
	}
	public void enableForcefeild()
	{
		if (PlayerPrefs.GetString("force field") == "true")
		{
			PlayerPrefs.SetString("force field", "false");
			GameObject forcefieldClone = Instantiate(forcefield);
			Transform player = GameObject.FindGameObjectWithTag("Player").transform;
			forcefieldClone.transform.SetParent(player);
			forcefieldClone.transform.localEulerAngles = Vector3.zero;
			forcefieldClone.transform.localPosition = new Vector3(0.27f, 0.67f, 0);

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
			if (enemieskilled % 10 == 0 && enemieskilled != 0)
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
