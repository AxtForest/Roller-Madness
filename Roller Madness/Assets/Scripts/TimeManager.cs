using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private bool gameFinished = false;
    private float Zaman = 5f;
    public bool gameOver = false;
    [SerializeField] private Text TimeTxt;
    [SerializeField] GameObject WinPanel, LosePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>= Zaman && gameOver == false)
        {
            gameFinished = true;
            WinPanel.gameObject.SetActive(true);
            LosePanel.gameObject.SetActive(false);
        }
        if(gameOver == true)
        {
            LosePanel.gameObject.SetActive(true);
            WinPanel.gameObject.SetActive(false);
            
        }
        UpdateTheTimer();
    }
    private void UpdateTheTimer()
    {
        TimeTxt.text = "Time: " + (int)Time.time;//Casting
    }
}
