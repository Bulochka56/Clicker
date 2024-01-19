using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour
{
    public  int money;
    public  int rate = 1;


    public Text moneyText;
    public Text tapScore;

    public void Click() 
    {
        money += rate;
        PlayerPrefs.SetInt("money", money);
    }
    

    void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 1);
    }

    void Update()
    {
        moneyText.text = "$" + money.ToString();
        PlayerPrefs.SetInt("rate", rate);
        tapScore.text = "$" + rate.ToString() + " за тап";
    }
}
