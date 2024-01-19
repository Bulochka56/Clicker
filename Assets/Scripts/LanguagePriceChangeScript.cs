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
            htmlBuy.text = "�������\n" +
            ((float)languageUpgradeScript.htmlBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            htmlBuy.text = "�������\n" +
            languageUpgradeScript.htmlBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("htmlBuyText", htmlBuy.text);
    }
    public void HtmlUpChange() {
        if (languageUpgradeScript.htmlUpPrice >= 1000) {
            htmlUpgrade.text = "��������\n" +
            ((float)languageUpgradeScript.htmlUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            htmlUpgrade.text = "��������\n" +
            languageUpgradeScript.htmlUpPrice.ToString() + "$";
        }
        if (languageUpgradeScript.htmlLvl.ToString().EndsWith("1")) {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " ������ � �������";
        } else if (languageUpgradeScript.htmlLvl.ToString().EndsWith("2") || languageUpgradeScript.htmlLvl.ToString().EndsWith("3") || languageUpgradeScript.htmlLvl.ToString().EndsWith("4")) {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " ������ � �������";
        } else {
            htmlTap.text = "+" + languageUpgradeScript.htmlLvl.ToString() + " ����� � �������";
        }       
        htmlLVL.text = languageUpgradeScript.htmlLvl.ToString() + " lvl";
        PlayerPrefs.SetString("htmlUpgradeText", htmlUpgrade.text);
        PlayerPrefs.SetString("htmlTapText", htmlTap.text);
        PlayerPrefs.SetString("htmlLVLText", htmlLVL.text);
    }
    public void JSBuyChange() {
        if (languageUpgradeScript.jsBuyPrice >= 1000) {
            jsBuy.text = "�������\n" +
            ((float)languageUpgradeScript.jsBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            jsBuy.text = "�������\n" +
            languageUpgradeScript.jsBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("jsBuyText", jsBuy.text);
    }
    public void JSUpChange() {
        if (languageUpgradeScript.jsUpPrice >= 1000) {
            jsUpgrade.text = "��������\n" +
            ((float)languageUpgradeScript.jsUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            jsUpgrade.text = "��������\n" +
            languageUpgradeScript.jsUpPrice.ToString() + "$";
        }
        jsTap.text = "+" + (languageUpgradeScript.jsLvl * 5).ToString() + " ����� � �������";
        jsLVL.text = languageUpgradeScript.jsLvl.ToString() + " lvl";
        PlayerPrefs.SetString("jsUpgradeText", jsUpgrade.text);
        PlayerPrefs.SetString("jsTapText", jsTap.text);
        PlayerPrefs.SetString("jsLVLText", jsLVL.text);
    }
    public void PytBuyChange() {
        if (languageUpgradeScript.pytBuyPrice >= 1000) {
            pytBuy.text = "�������\n" +
            ((float)languageUpgradeScript.pytBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            pytBuy.text = "�������\n" +
            languageUpgradeScript.pytBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("pytBuyText", pytBuy.text);
    }
    public void PytUpChange() {
        if (languageUpgradeScript.pytUpPrice >= 1000) {
            pytUpgrade.text = "��������\n" +
            ((float)languageUpgradeScript.pytUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            pytUpgrade.text = "��������\n" +
            languageUpgradeScript.pytUpPrice.ToString() + "$";
        }
        pytTap.text = "+" + (languageUpgradeScript.pytLvl * 15).ToString() + " ����� � �������";
        pytLVL.text = languageUpgradeScript.pytLvl.ToString() + " lvl";
        PlayerPrefs.SetString("pytUpgradeText", pytUpgrade.text);
        PlayerPrefs.SetString("htmlTapText", pytTap.text);
        PlayerPrefs.SetString("htmlLVLText", pytLVL.text);
    }
    public void CshBuyChange() {
        if (languageUpgradeScript.cshBuyPrice >= 1000) {
            cshBuy.text = "�������\n" +
            ((float)languageUpgradeScript.cshBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            cshBuy.text = "�������\n" +
            languageUpgradeScript.cshBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("cshBuyText", cshBuy.text);
    }
    public void CshUpChange() {
        if (languageUpgradeScript.cshUpPrice >= 1000) {
            cshUpgrade.text = "��������\n" +
            ((float)languageUpgradeScript.cshUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            cshUpgrade.text = "��������\n" +
            languageUpgradeScript.cshUpPrice.ToString() + "$";
        }
        cshTap.text = "+" + (languageUpgradeScript.cshLvl * 30).ToString() + " ����� � �������";
        cshLVL.text = languageUpgradeScript.cshLvl.ToString() + " lvl";
        PlayerPrefs.SetString("cshUpgradeText", cshUpgrade.text);
        PlayerPrefs.SetString("cshTapText", cshTap.text);
        PlayerPrefs.SetString("cshLVLText", cshLVL.text);
    }
    public void JavaBuyChange() {
        if (languageUpgradeScript.javaBuyPrice >= 1000) {
            javaBuy.text = "�������\n" +
            ((float)languageUpgradeScript.javaBuyPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            javaBuy.text = "�������\n" +
            languageUpgradeScript.javaBuyPrice.ToString() + "$";
        }
        PlayerPrefs.SetString("javaBuyText", javaBuy.text);
    }
    public void JavaUpChange() {
        if (languageUpgradeScript.javaUpPrice >= 1000) {
            javaUpgrade.text = "��������\n" +
            ((float)languageUpgradeScript.javaUpPrice / 1000).ToString("#.##") + "K" + "$";
        } else {
            javaUpgrade.text = "��������\n" +
            languageUpgradeScript.javaUpPrice.ToString() + "$";
        }
        javaTap.text = "+" + (languageUpgradeScript.javaLvl * 50).ToString() + " ����� � �������";
        javaLVL.text = languageUpgradeScript.javaLvl.ToString() + " lvl";
        PlayerPrefs.SetString("javaUpgradeText", javaUpgrade.text);
        PlayerPrefs.SetString("javaTapText", javaTap.text);
        PlayerPrefs.SetString("javaLVLText", javaLVL.text);
    }
    // Start is called before the first fpyte update
    void Start() {
        languageUpgradeScript = GetComponent<LanguageUpgradeScript>();
        htmlBuy.text = PlayerPrefs.GetString("htmlBuyText", "�������\n10$");
        htmlUpgrade.text = PlayerPrefs.GetString("htmlUpgradeText", "��������\n1K$");
        htmlTap.text = PlayerPrefs.GetString("htmlTapText", "+1 ������ � �������");
        htmlLVL.text = PlayerPrefs.GetString("htmlLVLText", "1 lvl");

        jsBuy.text = PlayerPrefs.GetString("jsBuyText", "�������\n100$");
        jsUpgrade.text = PlayerPrefs.GetString("jsUpgradeText", "��������\n5K$");
        jsTap.text = PlayerPrefs.GetString("jsTapText", "+5 ����� � �������");
        jsLVL.text = PlayerPrefs.GetString("jsLVLText", "1 lvl");

        pytBuy.text = PlayerPrefs.GetString("pytBuyText", "�������\n500$");
        pytUpgrade.text = PlayerPrefs.GetString("pytUpgradeText", "��������\n10K$");
        pytTap.text = PlayerPrefs.GetString("pytTapText", "+15 ����� � �������");
        pytLVL.text = PlayerPrefs.GetString("pytLVLText", "1 lvl");

        cshBuy.text = PlayerPrefs.GetString("cshBuyText", "�������\n1K$");
        cshUpgrade.text = PlayerPrefs.GetString("cshUpgradeText", "��������\n25K$");
        cshTap.text = PlayerPrefs.GetString("cshTapText", "+30 ����� � �������");
        cshLVL.text = PlayerPrefs.GetString("cshLVLText", "1 lvl");

        javaBuy.text = PlayerPrefs.GetString("javaBuyText", "�������\n10K$");
        javaUpgrade.text = PlayerPrefs.GetString("javaUpgradeText", "��������\n100K$");
        javaTap.text = PlayerPrefs.GetString("javaTapText", "+50 ����� � �������");
        javaLVL.text = PlayerPrefs.GetString("javaLVLText", "1 lvl");
    }
}
