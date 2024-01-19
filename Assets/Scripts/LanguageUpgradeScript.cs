using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageUpgradeScript : MonoBehaviour
{
    public int rate;
    public int money;

    public int htmlLvl;
    public int htmlRate;
    public int htmlBuyPrice;
    public int htmlUpPrice;

    public int jsLvl;
    public int jsRate;
    public int jsBuyPrice;
    public int jsUpPrice;

    public int pytLvl;
    public int pytRate;
    public int pytBuyPrice;
    public int pytUpPrice;

    public int cshLvl;
    public int cshRate;
    public int cshBuyPrice;
    public int cshUpPrice;

    public int javaLvl;
    public int javaRate;
    public int javaBuyPrice;
    public int javaUpPrice;

    public Text moneyText;
    public Text tapScore;

    public Image htmlBuy;
    public Image htmlUp;
    public Image jsBuy;
    public Image jsUp;
    public Image pytBuy;
    public Image pytUp;
    public Image cshBuy;
    public Image cshUp;
    public Image javaBuy;
    public Image javaUp;
    public void BuyHtml() {
        if (money >= htmlBuyPrice) {
            money -= htmlBuyPrice;
            htmlRate+=htmlLvl;
            htmlBuyPrice = Mathf.RoundToInt(htmlBuyPrice * 1.4f);
            PlayerPrefs.SetInt("htmlRate", htmlRate);
            PlayerPrefs.SetInt("htmlBuyPrice", htmlBuyPrice);
        }
    }
    public void UpgradeHtml() {
        if (money >= htmlUpPrice) {
            money -= htmlUpPrice;
            htmlLvl++;
            htmlRate += htmlRate;
            htmlUpPrice = Mathf.RoundToInt(htmlUpPrice * 1.6f);
            PlayerPrefs.SetInt("htmlRate", htmlRate);
            PlayerPrefs.SetInt("htmlLvl", htmlLvl);
            PlayerPrefs.SetInt("htmlUpPrice", htmlUpPrice);
        }
    }

    public void BuyJS() {
        if (money >= jsBuyPrice) {
            money -= jsBuyPrice;
            jsRate+=5*jsLvl;
            jsBuyPrice = Mathf.RoundToInt(jsBuyPrice * 1.4f);
            PlayerPrefs.SetInt("jsRate", jsRate);
            PlayerPrefs.SetInt("jsBuyPrice", jsBuyPrice);
        }
    }
    public void UpgradeJS() {
        if (money >= jsUpPrice) {
            money -= jsUpPrice;
            jsLvl++;
            jsRate += jsRate;
            jsUpPrice = Mathf.RoundToInt(jsUpPrice * 1.6f);
            PlayerPrefs.SetInt("jsRate", jsRate);
            PlayerPrefs.SetInt("jsLvl", jsLvl);
            PlayerPrefs.SetInt("jsUpPrice", jsUpPrice);
        }
    }

    public void BuyPyt() {
        if (money >= pytBuyPrice) {
            money -= pytBuyPrice;
            pytRate+=15*pytLvl;
            pytBuyPrice = Mathf.RoundToInt(pytBuyPrice * 1.4f);
            PlayerPrefs.SetInt("pytRate", pytRate);
            PlayerPrefs.SetInt("pytBuyPrice", pytBuyPrice);
        }
    }
    public void UpgradePyt() {
        if (money >= pytUpPrice) {
            money -= pytUpPrice;
            pytLvl++;
            pytRate += pytRate;
            pytUpPrice = Mathf.RoundToInt(pytUpPrice * 1.6f);
            PlayerPrefs.SetInt("pytRate", pytRate);
            PlayerPrefs.SetInt("pytLvl", pytLvl);
            PlayerPrefs.SetInt("pytUpPrice", pytUpPrice);
        }
    }

    public void BuyCsh() {
        if (money >= cshBuyPrice) {
            money -= cshBuyPrice;
            cshRate+=30*cshLvl;
            cshBuyPrice = Mathf.RoundToInt(cshBuyPrice * 1.4f);
            PlayerPrefs.SetInt("cshRate", cshRate);
            PlayerPrefs.SetInt("cshBuyPrice", cshBuyPrice);
        }
    }
    public void UpgradeCsh() {
        if (money >= cshUpPrice) {
            money -= cshUpPrice;
            cshLvl++;
            cshRate += cshRate;
            cshUpPrice = Mathf.RoundToInt(cshUpPrice * 1.6f);
            PlayerPrefs.SetInt("cshRate", cshRate);
            PlayerPrefs.SetInt("cshLvl", cshLvl);
            PlayerPrefs.SetInt("cshUpPrice", cshUpPrice);
        }
    }

    public void BuyJava() {
        if (money >= javaBuyPrice) {
            money -= javaBuyPrice;
            javaRate+=50*javaLvl;
            javaBuyPrice = Mathf.RoundToInt(javaBuyPrice * 1.4f);
            PlayerPrefs.SetInt("javaRate", javaRate);
            PlayerPrefs.SetInt("javaBuyPrice", javaBuyPrice);
        }
    }
    public void UpgradeJava() {
        if (money >= javaUpPrice) {
            money -= javaUpPrice;
            javaLvl++;
            javaRate += javaRate;
            javaUpPrice = Mathf.RoundToInt(javaUpPrice * 1.6f);
            PlayerPrefs.SetInt("javaRate", javaRate);
            PlayerPrefs.SetInt("javaLvl", javaLvl);
            PlayerPrefs.SetInt("javaUpPrice", javaUpPrice);
        }
    }
    // Start is called before the first fpyte update
    void Start() {
        money = PlayerPrefs.GetInt("money");
        rate = PlayerPrefs.GetInt("rate");
        htmlLvl = PlayerPrefs.GetInt("htmlLvl", 1);
        htmlRate = PlayerPrefs.GetInt("htmlRate", 0);
        htmlBuyPrice = PlayerPrefs.GetInt("htmlBuyPrice", 10);
        htmlUpPrice = PlayerPrefs.GetInt("htmlUpPrice", 1000);

        jsLvl = PlayerPrefs.GetInt("jsLvl", 1);
        jsRate = PlayerPrefs.GetInt("jsRate", 0);
        jsBuyPrice = PlayerPrefs.GetInt("jsBuyPrice", 100);
        jsUpPrice = PlayerPrefs.GetInt("jsUpPrice", 5000);

        pytLvl = PlayerPrefs.GetInt("pytLvl", 1);
        pytRate = PlayerPrefs.GetInt("pytRate", 0);
        pytBuyPrice = PlayerPrefs.GetInt("pytBuyPrice", 500);
        pytUpPrice = PlayerPrefs.GetInt("pytUpPrice", 10000);

        cshLvl = PlayerPrefs.GetInt("cshLvl", 1);
        cshRate = PlayerPrefs.GetInt("cshRate", 0);
        cshBuyPrice = PlayerPrefs.GetInt("cshBuyPrice", 1000);
        cshUpPrice = PlayerPrefs.GetInt("cshUpPrice", 25000);

        javaLvl = PlayerPrefs.GetInt("javaLvl", 1);
        javaRate = PlayerPrefs.GetInt("javaRate", 0);
        javaBuyPrice = PlayerPrefs.GetInt("javaBuyPrice", 10000);
        javaUpPrice = PlayerPrefs.GetInt("javaUpPrice", 100000);
    }

    // Update is called once per fpyte
    void Update() {
        moneyText.text = "$" + money.ToString();
        tapScore.text = "$" + rate.ToString() + " за тап";
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("rate", rate);
        if (money >= htmlBuyPrice) {
            htmlBuy.color = new Color32(20, 79, 19, 255);
        } else { htmlBuy.color = new Color32(0, 0, 0, 0); }
        if (money >= htmlUpPrice) {
            htmlUp.color = new Color32(20, 79, 19, 255);
        } else { htmlUp.color = new Color32(0, 0, 0, 0); }

        if (money >= jsBuyPrice) {
            jsBuy.color = new Color32(20, 79, 19, 255);
        } else {
            jsBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= jsUpPrice) {
            jsUp.color = new Color32(20, 79, 19, 255);
        } else {
            jsUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= pytBuyPrice) {
            pytBuy.color = new Color32(20, 79, 19, 255);
        } else {
            pytBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= pytUpPrice) {
            pytUp.color = new Color32(20, 79, 19, 255);
        } else {
            pytUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= cshBuyPrice) {
            cshBuy.color = new Color32(20, 79, 19, 255);
        } else {
            cshBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= cshUpPrice) {
            cshUp.color = new Color32(20, 79, 19, 255);
        } else {
            cshUp.color = new Color32(0, 0, 0, 0);
        }

        if (money >= javaBuyPrice) {
            javaBuy.color = new Color32(20, 79, 19, 255);
        } else {
            javaBuy.color = new Color32(0, 0, 0, 0);
        }
        if (money >= javaUpPrice) {
            javaUp.color = new Color32(20, 79, 19, 255);
        } else {
            javaUp.color = new Color32(0, 0, 0, 0);
        }
    }
}
