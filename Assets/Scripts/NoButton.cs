using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : MonoBehaviour
{
    public Image trollFace;
    public Image thinking;

    public void OnClicked()
    {
        ChangePosition();        
        ChangeMeme();
    }

    void ChangePosition()
    {
        float minX = -250;
        float maxX = 250;
        float minY = 125;
        float maxY = -460;
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        transform.localPosition = new Vector3(randomX, randomY, 0);
    }

    void ChangeMeme()
    {
        thinking.gameObject.SetActive(false);
        trollFace.gameObject.SetActive(true);
    }
}
