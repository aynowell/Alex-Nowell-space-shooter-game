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
        
        money = PlayerPrefs.GetFloat("mula");
        moneyText.text = "money:" + money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buy(float amount)
    {
        if (money - amount >= 0) {
            money = money - amount;
            PlayerPrefs.SetFloat("mula", money);
            moneyText.text = "money:" + money.ToString();
        }
    }
}
