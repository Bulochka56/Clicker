using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTabs : MonoBehaviour
{
    public bool status;
    public Canvas jobs;
    public Canvas orders;

    public Image order;
    public Image job;

    public void JobClick() 
    {
        if(!status) {
            orders.gameObject.SetActive(false);
            jobs.gameObject.SetActive(true); 
            job.color = new Color32(27,96,26,200);
            order.color = new Color32(20,79,19,200);
            status= true;
        }
    }
    public void OrderClick() {
        if (status) {
            orders.gameObject.SetActive(true);
            jobs.gameObject.SetActive(false);
            job.color = new Color32(20, 79, 19, 200);
            order.color = new Color32(27, 96, 26, 200);
            status= false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        status = true;
        orders.gameObject.SetActive(false);
        jobs.gameObject.SetActive(true);
        job.color = new Color32(27, 96, 26, 200);
        order.color = new Color32(20, 79, 19, 200);
        status = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
