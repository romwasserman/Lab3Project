using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class PlayerInfo : MonoBehaviour
{
    public static int health = 5;
    public static int points;
    public TMP_Text HealthText;
    public TMP_Text PointsText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = "Points: " + points;
        HealthText.text = "Health: " + health;


        if (health <= 0)
        {
            Time.timeScale = 0;
            health = 0;
        }
        if (points == 10)
        {
            Time.timeScale = 0;
        }






    }
   

}
