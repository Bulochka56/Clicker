using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguagePriceChangeScript : MonoBehaviour
{
    public LanguageUpgradeScript languageUpgradeScript;

    public Text htmlBuy;
    public Text htmlUpgrade;
    public Text htmlLVL;
    public Text htmlTap;

    public Text jsBuy;
    public Text jsUpgrade;
    public Text jsLVL;
    public Text jsTap;

    public Text pytBuy;
    public Text pytUpgrade;
    public Text pytLVL;
    public Text pytTap;

    public Text cshBuy;
    public Text cshUpgrade;
    public Text cshLVL;
    public Text cshTap;

    public Text javaBuy;
    public Text javaUpgrade;
    public Text javaLVL;
    public Text javaTap;

    public void HtmlBuyChange() {
        if (languageUpgradeScript.htmlBuyPrice >= 1000) {
            htmlBuy.text = "Покупка\n" +
            ((float)languageUpgradeScript.htmlBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            htmlBuy.text = "Покупка\n" +
            languageUpgradeScript.htmlBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("htmlBuyText", htmlBuy.text);
    }
    public void HtmlUpChange() {
        if (languageUpgradeScript.htmlUpPrice >= 1000) {
            htmlUpgrade.text = "Улушение\n" +
            ((float)languageUpgradeScript.htmlUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            htmlUpgrade.text = "Улушение\n" +
            languageUpgradeScript.htmlUpPrice.ToString() + "$";
        }
        if (languageUpgradeScript.htmlLvl.ToString().EndsWith("1")) {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " строка в секунду";
        } else if (languageUpgradeScript.htmlLvl.ToString().EndsWith("2") || languageUpgradeScript.htmlLvl.ToString().EndsWith("3") || languageUpgradeScript.htmlLvl.ToString().EndsWith("4")) {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " строки в секунду";
        } else {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " строк в секунду";
        }       
        htmlLVL.text = languageUpgradeScript.htmlLvl.ToString() + " lvl";
        PlayerPrefs.SetString("htmlUpgradeText", htmlUpgrade.text);
        PlayerPrefs.SetString("htmlTapText", htmlTap.text);
        PlayerPrefs.SetString("htmlLVLText", htmlLVL.text);
    }
    public void JSBuyChange() {
        if (languageUpgradeScript.jsBuyPrice >= 1000) {
            jsBuy.text = "Покупка\n" +
            ((float)languageUpgradeScript.jsBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            jsBuy.text = "Покупка\n" +
            languageUpgradeScript.jsBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("jsBuyText", jsBuy.text);
    }
    public void JSUpChange() {
        if (languageUpgradeScript.jsUpPrice >= 1000) {
            jsUpgrade.text = "Улушение\n" +
            ((float)languageUpgradeScript.jsUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            jsUpgrade.text = "Улушение\n" +
            languageUpgradeScript.jsUpPrice.ToString() + "$";
        }
        jsTap.text = "+" + (languageUpgradeScript.jsLvl * 5).ToString() + " строк в секунду";
        jsLVL.text = languageUpgradeScript.jsLvl.ToString() + " lvl";
        PlayerPrefs.SetString("jsUpgradeText", jsUpgrade.text);
        PlayerPrefs.SetString("jsTapText", jsTap.text);
        PlayerPrefs.SetString("jsLVLText", jsLVL.text);
    }
    public void PytBuyChange() {
        if (languageUpgradeScript.pytBuyPrice >= 1000) {
            pytBuy.text = "Покупка\n" +
            ((float)languageUpgradeScript.pytBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            pytBuy.text = "Покупка\n" +
            languageUpgradeScript.pytBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("pytBuyText", pytBuy.text);
    }
    public void PytUpChange() {
        if (languageUpgradeScript.pytUpPrice >= 1000) {
            pytUpgrade.text = "Улушение\n" +
            ((float)languageUpgradeScript.pytUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            pytUpgrade.text = "Улушение\n" +
            languageUpgradeScript.pytUpPrice.ToString() + "$";
        }
        pytTap.text = "+" + (languageUpgradeScript.pytLvl * 15).ToString() + " строк в секунду";
        pytLVL.text = languageUpgradeScript.pytLvl.ToString() + " lvl";
        PlayerPrefs.SetString("pytUpgradeText", pytUpgrade.text);
        PlayerPrefs.SetString("htmlTapText", pytTap.text);
        PlayerPrefs.SetString("htmlLVLText", pytLVL.text);
    }
    public void CshBuyChange() {
        if (languageUpgradeScript.cshBuyPrice >= 1000) {
            cshBuy.text = "Покупка\n" +
            ((float)languageUpgradeScript.cshBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            cshBuy.text = "Покупка\n" +
            languageUpgradeScript.cshBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("cshBuyText", cshBuy.text);
    }
    public void CshUpChange() {
        if (languageUpgradeScript.cshUpPrice >= 1000) {
            cshUpgrade.text = "Улушение\n" +
            ((float)languageUpgradeScript.cshUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            cshUpgrade.text = "Улушение\n" +
            languageUpgradeScript.cshUpPrice.ToString() + "$";
        }
        cshTap.text = "+" + (languageUpgradeScript.cshLvl * 30).ToString() + " строк в секунду";
        cshLVL.text = languageUpgradeScript.cshLvl.ToString() + " lvl";
        PlayerPrefs.SetString("cshUpgradeText", cshUpgrade.text);
        PlayerPrefs.SetString("cshTapText", cshTap.text);
        PlayerPrefs.SetString("cshLVLText", cshLVL.text);
    }
    public void JavaBuyChange() {
        if (languageUpgradeScript.javaBuyPrice >= 1000) {
            javaBuy.text = "Покупка\n" +
            ((float)languageUpgradeScript.javaBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            javaBuy.text = "Покупка\n" +
            languageUpgradeScript.javaBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("javaBuyText", javaBuy.text);
    }
    public void JavaUpChange() {
        if (languageUpgradeScript.javaUpPrice >= 1000) {
            javaUpgrade.text = "Улушение\n" +
            ((float)languageUpgradeScript.javaUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            javaUpgrade.text = "Улушение\n" +
            languageUpgradeScript.javaUpPrice.ToString() + "$";
        }
        javaTap.text = "+" + (languageUpgradeScript.javaLvl * 50).ToString() + " строк в секунду";
        javaLVL.text = languageUpgradeScript.javaLvl.ToString() + " lvl";
        PlayerPrefs.SetString("javaUpgradeText", javaUpgrade.text);
        PlayerPrefs.SetString("javaTapText", javaTap.text);
        PlayerPrefs.SetString("javaLVLText", javaLVL.text);
    }
    // Start is called before the first fpyte update
    void Start() {
        languageUpgradeScript = GetComponent<LanguageUpgradeScript>();
        htmlBuy.text = PlayerPrefs.GetString("htmlBuyText", "Покупка\n10$");
        htmlUpgrade.text = PlayerPrefs.GetString("htmlUpgradeText", "Улушение\n1K$");
        htmlTap.text = PlayerPrefs.GetString("htmlTapText", "+1 строка в секунду");
        htmlLVL.text = PlayerPrefs.GetString("htmlLVLText", "1 lvl");

        jsBuy.text = PlayerPrefs.GetString("jsBuyText", "Покупка\n100$");
        jsUpgrade.text = PlayerPrefs.GetString("jsUpgradeText", "Улушение\n5K$");
        jsTap.text = PlayerPrefs.GetString("jsTapText", "+5 строк в секунду");
        jsLVL.text = PlayerPrefs.GetString("jsLVLText", "1 lvl");

        pytBuy.text = PlayerPrefs.GetString("pytBuyText", "Покупка\n500$");
        pytUpgrade.text = PlayerPrefs.GetString("pytUpgradeText", "Улушение\n10K$");
        pytTap.text = PlayerPrefs.GetString("pytTapText", "+15 строк в секунду");
        pytLVL.text = PlayerPrefs.GetString("pytLVLText", "1 lvl");

        cshBuy.text = PlayerPrefs.GetString("cshBuyText", "Покупка\n1K$");
        cshUpgrade.text = PlayerPrefs.GetString("cshUpgradeText", "Улушение\n25K$");
        cshTap.text = PlayerPrefs.GetString("cshTapText", "+30 строк в секунду");
        cshLVL.text = PlayerPrefs.GetString("cshLVLText", "1 lvl");

        javaBuy.text = PlayerPrefs.GetString("javaBuyText", "Покупка\n10K$");
        javaUpgrade.text = PlayerPrefs.GetString("javaUpgradeText", "Улушение\n100K$");
        javaTap.text = PlayerPrefs.GetString("javaTapText", "+50 строк в секунду");
        javaLVL.text = PlayerPrefs.GetString("javaLVLText", "1 lvl");
    }
}
