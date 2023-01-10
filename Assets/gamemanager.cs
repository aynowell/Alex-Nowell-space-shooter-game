using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{

	public GameObject enemyPrefab;
	public GameObject bossPrefab;

	float spawnDistance = 12f;

	float enemyRate = 5;
	float nextEnemy = 1;

	public int enemieskilled;
	bool bossspawned;


	private void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		if (bossspawned == true)
        {
			return;
        }
		nextEnemy -= Time.deltaTime;

		if (nextEnemy <= 0)
		{
			nextEnemy = enemyRate;
			enemyRate *= 0.9f;
			if (enemyRate < 1)
				enemyRate = 1;

			Vector3 offset = Random.onUnitSphere;

			offset.z = 0;

			offset = offset.normalized * spawnDistance;
			if (enemieskilled == 15)
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
