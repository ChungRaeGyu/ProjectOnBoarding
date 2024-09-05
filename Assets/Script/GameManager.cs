using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public GameObject Player;
    public Monster currentMonster;

    public GameObject descriptionPanel;
    public SpriteRenderer image;
    public Text monsterName;
    public Text grade;
    public Text speed;
    public Text health;

    public void OpenPanel()
    {
        descriptionPanel.SetActive(true);
        image.sprite = currentMonster.GetComponent<SpriteRenderer>().sprite;
        monsterName.text = currentMonster.data.name.ToString();
        grade.text = currentMonster.data.grade.ToString();
        speed.text = currentMonster.data.speed.ToString();
        health.text = currentMonster.data.health.ToString();
    }

    public void ClosePanel()
    {
        descriptionPanel.SetActive(false);

    }
}
