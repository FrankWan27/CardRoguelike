using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


//Use UpdateDisplay() to update player hp
public class HealthDisplay : MonoBehaviour
{
    public static HealthDisplay Instance { get; private set; }
    public Text currentHealthText;
    public Text maxHealthText;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void UpdateDisplay()
    {
        currentHealthText.text = PlayerManager.Instance.health.ToString();
        maxHealthText.text = PlayerManager.Instance.maxHealth.ToString();
    }
}
