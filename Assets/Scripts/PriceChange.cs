using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceChange : MonoBehaviour
{
    public UpgradeScript upgradeScript;

    public Text procBuy;
    public Text procUpgrade;
    public Text procLVL;
    public Text procTap;

    public Text momBuy;
    public Text momUpgrade;
    public Text momLVL;
    public Text momTap;

    public Text ramBuy;
    public Text ramUpgrade;
    public Text ramLVL;
    public Text ramTap;

    public Text graphBuy;
    public Text graphUpgrade;
    public Text graphLVL;
    public Text graphTap;

    public Text serverBuy;
    public Text serverUpgrade;
    public Text serverLVL;
    public Text serverTap;

    public void ProcBuyChange() {
        if (upgradeScript.procBuyPrice >= 1000) {
            procBuy.text = "�������\n" +
            ((float)upgradeScript.procBuyPrice/1000).ToString("#.##") + "K" + "$";
        } else {
            procBuy.text = "�������\n" +
            upgradeScript.procBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("procBuyText", procBuy.text);
    }
    public void ProcUpChange() {
        if (upgradeScript.procUpPrice >= 1000) {
            procUpgrade.text = "��������\n" +
            ((float)upgradeScript.procUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            procUpgrade.text = "��������\n" +
            upgradeScript.procUpPrice.ToString() + "$";
        }
        procTap.text = "$" + upgradeScript.procLvl.ToString() + " �� ���";
        procLVL.text = upgradeScript.procLvl.ToString() + " lvl";
        PlayerPrefs.SetString("procUpgradeText", procUpgrade.text);
        PlayerPrefs.SetString("procTapText", procTap.text);
        PlayerPrefs.SetString("procLVLText", procLVL.text);
    }
    public void MBBuyChange() {
        if (upgradeScript.momBuyPrice >= 1000) {
            momBuy.text = "�������\n" +
            ((float)upgradeScript.momBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            momBuy.text = "�������\n" +
            upgradeScript.momBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("momBuyText", momBuy.text);
    }
    public void MBUpChange() {
        if (upgradeScript.momUpPrice >= 1000) {
            momUpgrade.text = "��������\n" +
            ((float)upgradeScript.momUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            momUpgrade.text = "��������\n" +
            upgradeScript.momUpPrice.ToString() + "$";
        }
        momTap.text = "$" + (upgradeScript.momLvl*5).ToString() + " �� ���";
        momLVL.text = upgradeScript.momLvl.ToString() + " lvl";
        PlayerPrefs.SetString("momUpgradeText", momUpgrade.text);
        PlayerPrefs.SetString("momTapText", momTap.text);
        PlayerPrefs.SetString("momLVLText", momLVL.text);
    }
    public void RamBuyChange() {
        if (upgradeScript.ramBuyPrice >= 1000) {
            ramBuy.text = "�������\n" +
            ((float)upgradeScript.ramBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            ramBuy.text = "�������\n" +
            upgradeScript.ramBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("ramBuyText", ramBuy.text);
    }
    public void RamUpChange() {
        if (upgradeScript.ramUpPrice >= 1000) {
            ramUpgrade.text = "��������\n" +
            ((float)upgradeScript.ramUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            ramUpgrade.text = "��������\n" +
            upgradeScript.ramUpPrice.ToString() + "$";
        }
        ramTap.text = "$" + (upgradeScript.ramLvl*15).ToString() + " �� ���";
        ramLVL.text = upgradeScript.ramLvl.ToString() + " lvl";
        PlayerPrefs.SetString("ramUpgradeText", ramUpgrade.text);
        PlayerPrefs.SetString("procTapText", ramTap.text);
        PlayerPrefs.SetString("procLVLText", ramLVL.text);
    }
    public void GraphBuyChange() {
        if (upgradeScript.graphBuyPrice >= 1000) {
            graphBuy.text = "�������\n" +
            ((float)upgradeScript.graphBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            graphBuy.text = "�������\n" +
            upgradeScript.graphBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("graphBuyText", graphBuy.text);
    }
    public void GraphUpChange() {
        if (upgradeScript.graphUpPrice >= 1000) {
            graphUpgrade.text = "��������\n" +
            ((float)upgradeScript.graphUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            graphUpgrade.text = "��������\n" +
            upgradeScript.graphUpPrice.ToString() + "$";
        }
        graphTap.text = "$" + (upgradeScript.graphLvl*30).ToString() + " �� ���";
        graphLVL.text = upgradeScript.graphLvl.ToString() + " lvl";
        PlayerPrefs.SetString("graphUpgradeText", graphUpgrade.text);
        PlayerPrefs.SetString("graphTapText", graphTap.text);
        PlayerPrefs.SetString("graphLVLText", graphLVL.text);
    }
    public void ServerBuyChange() {
        if (upgradeScript.serverBuyPrice >= 1000) {
            serverBuy.text = "�������\n" +
            ((float)upgradeScript.serverBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            serverBuy.text = "�������\n" +
            upgradeScript.serverBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("serverBuyText", serverBuy.text);
    }
    public void ServerUpChange() {
        if (upgradeScript.serverUpPrice >= 1000) {
            serverUpgrade.text = "��������\n" +
            ((float)upgradeScript.serverUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            serverUpgrade.text = "��������\n" +
            upgradeScript.serverUpPrice.ToString() + "$";
        }
        serverTap.text = "$" + (upgradeScript.serverLvl*50).ToString() + " �� ���";
        serverLVL.text = upgradeScript.serverLvl.ToString() + " lvl";
        PlayerPrefs.SetString("serverUpgradeText", serverUpgrade.text);
        PlayerPrefs.SetString("serverTapText", serverTap.text);
        PlayerPrefs.SetString("serverLVLText", serverLVL.text);
    }
    // Start is called before the first frame update
    void Start()
    {
        upgradeScript = GetComponent<UpgradeScript>();
        procBuy.text = PlayerPrefs.GetString("procBuyText", "�������\n10$");
        procUpgrade.text = PlayerPrefs.GetString("procUpgradeText","��������\n1K$");
        procTap.text = PlayerPrefs.GetString("procTapText", "$1 �� ���");
        procLVL.text = PlayerPrefs.GetString("procLVLText","1 lvl");

        momBuy.text = PlayerPrefs.GetString("momBuyText", "�������\n100$");
        momUpgrade.text = PlayerPrefs.GetString("momUpgradeText", "��������\n5K$");
        momTap.text = PlayerPrefs.GetString("momTapText", "$5 �� ���");
        momLVL.text = PlayerPrefs.GetString("momLVLText", "1 lvl");

        ramBuy.text = PlayerPrefs.GetString("ramBuyText", "�������\n500$");
        ramUpgrade.text = PlayerPrefs.GetString("ramUpgradeText", "��������\n10K$");
        ramTap.text = PlayerPrefs.GetString("ramTapText", "$15 �� ���");
        ramLVL.text = PlayerPrefs.GetString("ramLVLText", "1 lvl");

        graphBuy.text = PlayerPrefs.GetString("graphBuyText", "�������\n1K$");
        graphUpgrade.text = PlayerPrefs.GetString("graphUpgradeText", "��������\n25K$");
        graphTap.text = PlayerPrefs.GetString("graphTapText", "$30 �� ���");
        graphLVL.text = PlayerPrefs.GetString("graphLVLText", "1 lvl");

        serverBuy.text = PlayerPrefs.GetString("serverBuyText", "�������\n10K$");
        serverUpgrade.text = PlayerPrefs.GetString("serverUpgradeText", "��������\n100K$");
        serverTap.text = PlayerPrefs.GetString("serverTapText", "$50 �� ���");
        serverLVL.text = PlayerPrefs.GetString("serverLVLText", "1 lvl");
    }

}
