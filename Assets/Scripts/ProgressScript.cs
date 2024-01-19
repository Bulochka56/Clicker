using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
    public GameObject html;
    public GameObject js;
    public GameObject python;
    public GameObject csharp;
    public GameObject java;

    public int htmlRate;
    public int jsRate;
    public int pythonRate;
    public int csharpRate;
    public int javaRate;

    public int htmlProgress;
    public int jsProgress;
    public int pythonProgress;
    public int csharpProgress;
    public int javaProgress;

    public int htmlPrice;
    public int jsPrice;
    public int pythonPrice;
    public int csharpPrice;
    public int javaPrice;

    public int htmlNeed;
    public int jsNeed;
    public int pythonNeed;
    public int csharpNeed;
    public int javaNeed;

    public bool htmlStatus = false;
    public bool jsStatus = false;
    public bool pythonStatus = false ;
    public bool csharpStatus = false;
    public bool javaStatus = false;


    public Text htmlOrderText;
    public Text htmlProgressText;
    public Text htmlPriceText;
    public Text htmlRateText;

    public Text jsOrderText;
    public Text jsProgressText;
    public Text jsPriceText;
    public Text jsRateText;

    public Text pythonOrderText;
    public Text pythonProgressText;
    public Text pythonPriceText;
    public Text pythonRateText;

    public Text csharpOrderText;
    public Text csharpProgressText;
    public Text csharpPriceText;
    public Text csharpRateText;

    public Text javaOrderText;
    public Text javaProgressText;
    public Text javaPriceText;
    public Text javaRateText;

    public System.Random r = new System.Random();
    public ClickScript clickScript;
    // Start is called before the first frame update
    void Start()
    {
        htmlRate = PlayerPrefs.GetInt("htmlRate", 0);
        jsRate = PlayerPrefs.GetInt("jsRate", 0);
        pythonRate = PlayerPrefs.GetInt("pytRate", 0);
        csharpRate = PlayerPrefs.GetInt("cshRate", 0);
        javaRate = PlayerPrefs.GetInt("javaRate", 0);

        htmlRateText.text = htmlRate.ToString() + " стр/сек";
        jsRateText.text = jsRate.ToString() + " стр/сек";
        pythonRateText.text = pythonRate.ToString() + " стр/сек";
        csharpRateText.text = csharpRate.ToString() + " стр/сек";
        javaRateText.text = javaRate.ToString() + " стр/сек";

        if (htmlRate >= 1) {
            html.SetActive(true);
            htmlStatus = PlayerPrefs.GetInt("htmlStatus", 0) == 1;
            if (!htmlStatus) {
                HtmlStart();
            } else {
                htmlOrderText.text = PlayerPrefs.GetString("htmlOrderText");
                htmlProgressText.text = PlayerPrefs.GetString("htmlProgressText");
                htmlPriceText.text = PlayerPrefs.GetString("htmlPriceText");
                htmlProgress = PlayerPrefs.GetInt("htmlProgress");
                htmlNeed = PlayerPrefs.GetInt("htmlNeed");
                htmlPrice = PlayerPrefs.GetInt("htmlPrice");
                InvokeRepeating("HtmlProgress", 0f, 1f);
            }
        } else {
            html.SetActive(false);
        }
        if (jsRate >= 1) {
            js.SetActive(true);
            jsStatus = PlayerPrefs.GetInt("jsStatus", 0) == 1;
            if (!jsStatus) {
                JsStart();
            } else {
                jsOrderText.text = PlayerPrefs.GetString("jsOrderText");
                jsProgressText.text = PlayerPrefs.GetString("jsProgressText");
                jsPriceText.text = PlayerPrefs.GetString("jsPriceText");
                jsProgress = PlayerPrefs.GetInt("jsProgress");
                jsNeed = PlayerPrefs.GetInt("jsNeed");
                jsPrice = PlayerPrefs.GetInt("jsPrice");
                InvokeRepeating("JsProgress", 0f, 1f);
            }
        } else {
            js.SetActive(false);
        }
        if (pythonRate >= 1) {
            python.SetActive(true);
            pythonStatus = PlayerPrefs.GetInt("pythonStatus", 0) == 1;
            if (!pythonStatus) {
                PythonStart();
            } else {
                pythonOrderText.text = PlayerPrefs.GetString("pythonOrderText");
                pythonProgressText.text = PlayerPrefs.GetString("pythonProgressText");
                pythonPriceText.text = PlayerPrefs.GetString("pythonPriceText");
                pythonProgress = PlayerPrefs.GetInt("pythonProgress");
                pythonNeed = PlayerPrefs.GetInt("pythonNeed");
                pythonPrice = PlayerPrefs.GetInt("pythonPrice");
                InvokeRepeating("PythonProgress", 0f, 1f);
            }
        } else { 
            python.SetActive(false); }
        if(csharpRate >= 1) {
            csharp.SetActive(true);
            csharpStatus = PlayerPrefs.GetInt("csharpStatus", 0) == 1;
            if (!csharpStatus) {
                CsharpStart();
            } else {
                csharpOrderText.text = PlayerPrefs.GetString("csharpOrderText");
                csharpProgressText.text = PlayerPrefs.GetString("csharpProgressText");
                csharpPriceText.text = PlayerPrefs.GetString("csharpPriceText");
                csharpProgress = PlayerPrefs.GetInt("csharpProgress");
                csharpNeed = PlayerPrefs.GetInt("csharpNeed");
                csharpPrice = PlayerPrefs.GetInt("csharpPrice");
                InvokeRepeating("CsharpProgress", 0f, 1f);
            }
        } else { 
            csharp.SetActive(false);
        }
        if (javaRate >= 1) {
            java.SetActive(true);
            javaStatus = PlayerPrefs.GetInt("javaStatus", 0) == 1;
            if (!javaStatus) {
                JavaStart();
            } else {
                javaOrderText.text = PlayerPrefs.GetString("javaOrderText");
                javaProgressText.text = PlayerPrefs.GetString("javaProgressText");
                javaPriceText.text = PlayerPrefs.GetString("javaPriceText");
                javaProgress = PlayerPrefs.GetInt("javaProgress");
                javaNeed = PlayerPrefs.GetInt("javaNeed");
                javaPrice = PlayerPrefs.GetInt("javaPrice");
                InvokeRepeating("JavaProgress", 0f, 1f);
            }
        } else { 
            java.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        htmlProgressText.text = htmlProgress.ToString() + " строчек из " + htmlNeed.ToString();
        jsProgressText.text = jsProgress.ToString() + " строчек из " + jsNeed.ToString();
        pythonProgressText.text = pythonProgress.ToString() + " строчек из " + pythonNeed.ToString();
        csharpProgressText.text = csharpProgress.ToString() + " строчек из " + csharpNeed.ToString();
        javaProgressText.text = javaProgress.ToString() + " строчек из " + javaNeed.ToString();

    }

    void HtmlStart() {
        int num = r.Next(1, 4);
        htmlStatus = true;
        switch (num) {
            case 1:
                htmlOrderText.text = "Разработка Калькулятора";
                htmlProgressText.text = "0 строчек из 50";
                htmlPriceText.text = "38$";
                htmlProgress = 0;
                htmlNeed = 50;
                htmlPrice = 38;

                break;
            case 2:
                htmlOrderText.text = "Создание веб-сайта";
                htmlProgressText.text = "0 строчек из 200";
                htmlPriceText.text = "150$";
                htmlProgress = 0;
                htmlNeed = 200;
                htmlPrice = 150;
                break;
            case 3:
                htmlOrderText.text = "Верстка веб-сайта";
                htmlProgressText.text = "0 строчек из 500";
                htmlPriceText.text = "375$";
                htmlProgress = 0;
                htmlNeed = 500;
                htmlPrice = 375;
                break;
        }
        PlayerPrefs.SetInt("htmlStatus", htmlStatus ? 1 : 0);
        PlayerPrefs.SetString("htmlOrderText", htmlOrderText.text);
        PlayerPrefs.SetString("htmlProgressText", htmlProgressText.text);
        PlayerPrefs.SetString("htmlPriceText", htmlPriceText.text);
        PlayerPrefs.SetInt("htmlProgress", htmlProgress);
        PlayerPrefs.SetInt("htmlNeed", htmlNeed);
        PlayerPrefs.SetInt("htmlPrice", htmlPrice);
        InvokeRepeating("HtmlProgress", 0f, 1f);
    }
    void HtmlProgress() {
        if (htmlStatus) {
            htmlProgress += htmlRate;
            PlayerPrefs.SetInt("htmlProgress", htmlProgress);
        }
        if (htmlProgress >= htmlNeed) {
            HtmlEnd();
        }

    }

    void HtmlEnd() {
        clickScript.money += htmlPrice;
        PlayerPrefs.SetInt("money", clickScript.money);
        htmlStatus = false;
        CancelInvoke("HtmlProgress");
        HtmlStart();
    }

    void JsStart() {
        int num = r.Next(1, 4);
        jsStatus = true;
        switch (num) {
            case 1:
                jsOrderText.text = "Написание аддона к сайту";
                jsProgressText.text = "0 строчек из 700";
                jsPriceText.text = "525$";
                jsProgress = 0;
                jsNeed = 700;
                jsPrice = 525;

                break;
            case 2:
                jsOrderText.text = "Анимация для сайта";
                jsProgressText.text = "0 строчек из 600";
                jsPriceText.text = "450$";
                jsProgress = 0;
                jsNeed = 600;
                jsPrice = 450;
                break;
            case 3:
                jsOrderText.text = "Создание веб-чата";
                jsProgressText.text = "0 строчек из 1200";
                jsPriceText.text = "900$";
                jsProgress = 0;
                jsNeed = 1200;
                jsPrice = 900;
                break;
        }
        PlayerPrefs.SetInt("jsStatus", jsStatus ? 1 : 0);
        PlayerPrefs.SetString("jsOrderText", jsOrderText.text);
        PlayerPrefs.SetString("jsProgressText", jsProgressText.text);
        PlayerPrefs.SetString("jsPriceText", jsPriceText.text);
        PlayerPrefs.SetInt("jsProgress", jsProgress);
        PlayerPrefs.SetInt("jsNeed", jsNeed);
        PlayerPrefs.SetInt("jsPrice", jsPrice);
        InvokeRepeating("JsProgress", 0f, 1f);
    }
    void JsProgress() {
        if (jsStatus) {
            jsProgress += jsRate;
            PlayerPrefs.SetInt("jsProgress", jsProgress);
        }
        if (jsProgress >= jsNeed) {
            JsEnd();
        }

    }

    void JsEnd() {
        clickScript.money += jsPrice;
        PlayerPrefs.SetInt("money", clickScript.money);
        jsStatus = false;
        CancelInvoke("JsProgress");
        JsStart();
    }

    void PythonStart() {
        int num = r.Next(1, 4);
        pythonStatus = true;
        switch (num) {
            case 1:
                pythonOrderText.text = "Телеграмм-бот";
                pythonProgressText.text = "0 строчек из 1500";
                pythonPriceText.text = "1125$";
                pythonProgress = 0;
                pythonNeed = 1500;
                pythonPrice = 1125;

                break;
            case 2:
                pythonOrderText.text = "Веб-приложение";
                pythonProgressText.text = "0 строчек из 1700";
                pythonPriceText.text = "1275$";
                pythonProgress = 0;
                pythonNeed = 1700;
                pythonPrice = 1275;
                break;
            case 3:
                pythonOrderText.text = "Машинное обучение";
                pythonProgressText.text = "0 строчек из 2000";
                pythonPriceText.text = "1500$";
                pythonProgress = 0;
                pythonNeed = 2000;
                pythonPrice = 1500;
                break;
        }
        PlayerPrefs.SetInt("pythonStatus", pythonStatus ? 1 : 0);
        PlayerPrefs.SetString("pythonOrderText", pythonOrderText.text);
        PlayerPrefs.SetString("pythonProgressText", pythonProgressText.text);
        PlayerPrefs.SetString("pythonPriceText", pythonPriceText.text);
        PlayerPrefs.SetInt("pythonProgress", pythonProgress);
        PlayerPrefs.SetInt("pythonNeed", pythonNeed);
        PlayerPrefs.SetInt("pythonPrice", pythonPrice);
        InvokeRepeating("PythonProgress", 0f, 1f);
    }
    void PythonProgress() {
        if (pythonStatus) {
            pythonProgress += pythonRate;
            PlayerPrefs.SetInt("pythonProgress", pythonProgress);
        }
        if (pythonProgress >= pythonNeed) {
            PythonEnd();
        }

    }

    void PythonEnd() {
        clickScript.money += pythonPrice;
        PlayerPrefs.SetInt("money", clickScript.money);
        pythonStatus = false;
        CancelInvoke("PythonProgress");
        PythonStart();
    }

    void CsharpStart() {
        int num = r.Next(1, 4);
        csharpStatus = true;
        switch (num) {
            case 1:
                csharpOrderText.text = "Игра на Unity";
                csharpProgressText.text = "0 строчек из 2500";
                csharpPriceText.text = "1900$";
                csharpProgress = 0;
                csharpNeed = 2500;
                csharpPrice = 1900;

                break;
            case 2:
                csharpOrderText.text = "Веб-приложение на ASP.NET";
                csharpProgressText.text = "0 строчек из 2200";
                csharpPriceText.text = "1700$";
                csharpProgress = 0;
                csharpNeed = 2200;
                csharpPrice = 1700;
                break;
            case 3:
                csharpOrderText.text = "Система обработки изображений";
                csharpProgressText.text = "0 строчек из 2800";
                csharpPriceText.text = "2200$";
                csharpProgress = 0;
                csharpNeed = 2800;
                csharpPrice = 2200;
                break;
        }
        PlayerPrefs.SetInt("csharpStatus", csharpStatus ? 1 : 0);
        PlayerPrefs.SetString("csharpOrderText", csharpOrderText.text);
        PlayerPrefs.SetString("csharpProgressText", csharpProgressText.text);
        PlayerPrefs.SetString("csharpPriceText", csharpPriceText.text);
        PlayerPrefs.SetInt("csharpProgress", csharpProgress);
        PlayerPrefs.SetInt("csharpNeed", csharpNeed);
        PlayerPrefs.SetInt("csharpPrice", csharpPrice);
        InvokeRepeating("CsharpProgress", 0f, 1f);
    }
    void CsharpProgress() {
        if (csharpStatus) {
            csharpProgress += csharpRate;
            PlayerPrefs.SetInt("csharpProgress", csharpProgress);
        }
        if (csharpProgress >= csharpNeed) {
            CsharpEnd();
        }

    }

    void CsharpEnd() {
        clickScript.money += csharpPrice;
        PlayerPrefs.SetInt("money", clickScript.money);
        csharpStatus = false;
        CancelInvoke("CsharpProgress");
        CsharpStart();
    }

    void JavaStart() {
        int num = r.Next(1, 4);
        javaStatus = true;
        switch (num) {
            case 1:
                javaOrderText.text = "Мобильное приложение";
                javaProgressText.text = "0 строчек из 3000";
                javaPriceText.text = "2300$";
                javaProgress = 0;
                javaNeed = 3000;
                javaPrice = 2300;

                break;
            case 2:
                javaOrderText.text = "Desktop-приложение";
                javaProgressText.text = "0 строчек из 3200";
                javaPriceText.text = "2500$";
                javaProgress = 0;
                javaNeed = 3200;
                javaPrice = 2500;
                break;
            case 3:
                javaOrderText.text = "Распределенная система обработки данных";
                javaProgressText.text = "0 строчек из 4000";
                javaPriceText.text = "3250$";
                javaProgress = 0;
                javaNeed = 4000;
                javaPrice = 3250;
                break;
        }
        PlayerPrefs.SetInt("javaStatus", javaStatus ? 1 : 0);
        PlayerPrefs.SetString("javaOrderText", javaOrderText.text);
        PlayerPrefs.SetString("javaProgressText", javaProgressText.text);
        PlayerPrefs.SetString("javaPriceText", javaPriceText.text);
        PlayerPrefs.SetInt("javaProgress", javaProgress);
        PlayerPrefs.SetInt("javaNeed", javaNeed);
        PlayerPrefs.SetInt("javaPrice", javaPrice);
        InvokeRepeating("JavaProgress", 0f, 1f);
    }
    void JavaProgress() {
        if (javaStatus) {
            javaProgress += javaRate;
            PlayerPrefs.SetInt("javaProgress", javaProgress);
        }
        if (javaProgress >= javaNeed) {
            JavaEnd();
        }

    }

    void JavaEnd() {
        clickScript.money += javaPrice;
        PlayerPrefs.SetInt("money", clickScript.money);
        jsStatus = false;
        CancelInvoke("JavaProgress");
        JsStart();
    }
}
