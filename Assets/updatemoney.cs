using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updatemoney : MonoBehaviour
{
    public float money;
    public TMP_Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("mula", 100);
    }

    // Update is called once per frame
    void Update()
    {
        money = PlayerPrefs.GetFloat("mula");
        moneyText.text = "money:" + money.ToString();
    }

    public void buy(float amount)
    {
        if (money - amount >= 0) {
            money = money - amount;
            moneyText.text = "money:" + money.ToString();
        }
    }
}
