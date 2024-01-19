using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    public int rate;
    public int money;

    public int procLvl;
    public int procRate;
    public int procBuyPrice;
    public int procUpPrice;

    public int momLvl;
    public int momRate;
    public int momBuyPrice;
    public int momUpPrice;

    public int ramLvl;
    public int ramRate;
    public int ramBuyPrice;
    public int ramUpPrice;

    public int graphLvl;
    public int graphRate;
    public int graphBuyPrice;
    public int graphUpPrice;

    public int serverLvl;
    public int serverRate;
    public int serverBuyPrice;
    public int serverUpPrice;

    public Text moneyText;
    public Text tapScore;

    public Image procBuy;
    public Image procUp;
    public Image momBuy;
    public Image momUp;
    public Image ramBuy;
    public Image ramUp;
    public Image graphBuy;
    public Image graphUp;
    public Image serverBuy;
    public Image serverUp;
    public void BuyProc() {
        if (money >= procBuyPrice) { 
            money -= procBuyPrice;
            rate+= procLvl;
            procRate++;
            procBuyPrice = Mathf.RoundToInt(procBuyPrice * 1.4f);
            PlayerPrefs.SetInt("procRate", procRate);
            PlayerPrefs.SetInt("procBuyPrice", procBuyPrice);
        }
    }
    public void UpgradeProc() {
        if (money >= procUpPrice) { 
            money -= procUpPrice;
            procLvl++;
            procRate *= procLvl;
            rate += (procRate/procLvl);
            procUpPrice = Mathf.RoundToInt(procUpPrice * 1.6f);
            PlayerPrefs.SetInt("procLvl", procLvl);
            PlayerPrefs.SetInt("procUpPrice", procUpPrice);
        }
    }

    public void BuyMB() {
        if (money >= momBuyPrice) {
            money -= momBuyPrice;
            rate += momLvl*5;
            momRate++;
            momBuyPrice = Mathf.RoundToInt(momBuyPrice * 1.4f);
            PlayerPrefs.SetInt("momRate", momRate);
            PlayerPrefs.SetInt("momBuyPrice", momBuyPrice);
        }
    }
    public void UpgradeMB() {
        if (money >= momUpPrice) {
            money -= momUpPrice;
            momLvl++;
            momRate *= momLvl;
            rate += (momRate/ momLvl);
            momUpPrice = Mathf.RoundToInt(momUpPrice * 1.6f);
            PlayerPrefs.SetInt("momLvl", momLvl);
            PlayerPrefs.SetInt("momUpPrice", momUpPrice);
        }
    }

    public void BuyRam() {
        if (money >= ramBuyPrice) {
            money -= ramBuyPrice;
            rate += ramLvl * 15;
            ramRate++;
            ramBuyPrice = Mathf.RoundToInt(ramBuyPrice * 1.4f);
            PlayerPrefs.SetInt("ramRate", ramRate);
            PlayerPrefs.SetInt("ramBuyPrice", ramBuyPrice);
        }
    }
    public void UpgradeRam() {
        if (money >= ramUpPrice) {
            money -= ramUpPrice;
            ramLvl++;
            ramRate *= ramLvl;
            rate += (ramRate / ramLvl);
            ramUpPrice = Mathf.RoundToInt(ramUpPrice * 1.6f);
            PlayerPrefs.SetInt("ramLvl", ramLvl);
            PlayerPrefs.SetInt("ramUpPrice", ramUpPrice);
        }
    }

    public void BuyGraph() {
        if (money >= graphBuyPrice) {
            money -= graphBuyPrice;
            rate += graphLvl * 30;
            graphRate++;
            graphBuyPrice = Mathf.RoundToInt(graphBuyPrice * 1.4f);
            PlayerPrefs.SetInt("graphRate", graphRate);
            PlayerPrefs.SetInt("graphBuyPrice", graphBuyPrice);
        }
    }
    public void UpgradeGraph() {
        if (money >= graphUpPrice) {
            money -= graphUpPrice;
            graphLvl++;
            graphRate *= graphLvl;
            rate += (graphRate / graphLvl);
            graphUpPrice = Mathf.RoundToInt(graphUpPrice * 1.6f);
            PlayerPrefs.SetInt("graphLvl", graphLvl);
            PlayerPrefs.SetInt("graphUpPrice", graphUpPrice);
        }
    }

    public void BuyServ() {
        if (money >= serverBuyPrice) {
            money -= serverBuyPrice;
            rate += serverLvl * 50;
            serverRate++;
            serverBuyPrice = Mathf.RoundToInt(serverBuyPrice * 1.4f);
            PlayerPrefs.SetInt("serverRate", serverRate);
            PlayerPrefs.SetInt("serverBuyPrice", serverBuyPrice);
        }
    }
    public void UpgradeServ() {
        if (money >= serverUpPrice) {
            money -= serverUpPrice;
            serverLvl++;
            serverRate *= serverLvl;
            rate += (serverRate / serverLvl);
            serverUpPrice = Mathf.RoundToInt(serverUpPrice * 1.6f);
            PlayerPrefs.SetInt("serverLvl", serverLvl);
            PlayerPrefs.SetInt("serverUpPrice", serverUpPrice);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        rate = PlayerPrefs.GetInt("rate",1);

        procLvl = PlayerPrefs.GetInt("procLvl", 1);
        procRate = PlayerPrefs.GetInt("procRate", 0);
        procBuyPrice = PlayerPrefs.GetInt("procBuyPrice", 10);
        procUpPrice = PlayerPrefs.GetInt("procUpPrice", 1000);

        momLvl = PlayerPrefs.GetInt("momLvl", 1);
        momRate = PlayerPrefs.GetInt("momRate", 0);
        momBuyPrice = PlayerPrefs.GetInt("momBuyPrice", 100);
        momUpPrice = PlayerPrefs.GetInt("momUpPrice", 5000);

        ramLvl = PlayerPrefs.GetInt("ramLvl", 1);
        ramRate = PlayerPrefs.GetInt("ramRate", 0);
        ramBuyPrice = PlayerPrefs.GetInt("ramBuyPrice", 500);
        ramUpPrice = PlayerPrefs.GetInt("ramUpPrice", 10000);

        graphLvl = PlayerPrefs.GetInt("graphLvl", 1);
        graphRate = PlayerPrefs.GetInt("graphRate", 0);
        graphBuyPrice = PlayerPrefs.GetInt("graphBuyPrice", 1000);
        graphUpPrice = PlayerPrefs.GetInt("graphUpPrice", 25000);

        serverLvl = PlayerPrefs.GetInt("serverLvl", 1);
        serverRate = PlayerPrefs.GetInt("serverRate", 0);
        serverBuyPrice = PlayerPrefs.GetInt("serverBuyPrice", 10000);
        serverUpPrice = PlayerPrefs.GetInt("serverUpPrice", 100000);
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "$"+money.ToString();
        tapScore.text = "$"+rate.ToString()+" за тап";
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("rate", rate);
        if(money >= procBuyPrice) {
            procBuy.color = new Color32(20,79,19,255);
        } else { procBuy.color = new Color32(0, 0, 0, 0); }
        if (money >= procUpPrice) {
            procUp.color = new Color32(20, 79, 19, 255);
        } else { procUp.color = new Color32(0, 0, 0, 0); }

        if (money >= momBuyPrice) {
            momBuy.color = new Color32(20, 79, 19, 255);
        } else {
            momBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= momUpPrice) {
            momUp.color = new Color32(20, 79, 19, 255);
        } else {
            momUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= ramBuyPrice) {
            ramBuy.color = new Color32(20, 79, 19, 255);
        } else {
            ramBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= ramUpPrice) {
            ramUp.color = new Color32(20, 79, 19, 255);
        } else {
            ramUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= graphBuyPrice) {
            graphBuy.color = new Color32(20, 79, 19, 255);
        } else {
            graphBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= graphUpPrice) {
            graphUp.color = new Color32(20, 79, 19, 255);
        } else {
            graphUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= serverBuyPrice) {
            serverBuy.color = new Color32(20, 79, 19, 255);
        } else {
            serverBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= serverUpPrice) {
            serverUp.color = new Color32(20, 79, 19, 255);
        } else {
            serverUp.color = new Color32(0, 0, 0, 0);
        }
    }
}
