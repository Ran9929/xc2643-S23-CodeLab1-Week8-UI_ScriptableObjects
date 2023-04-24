using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    
    public FamilyScriptableObject currentLocation;

    public Button father;
    public Button son;
    public Button husband;
    public Button wife;
    
    // Start is called before the first frame update
    void Start()
    {
        TextAsset fileText = Resources.Load<TextAsset>("Data");
        
        Debug.Log(fileText.text);
        
        UpdateLocation();
    }

    void UpdateLocation()
    {
        title.text = currentLocation.name;

        if (currentLocation.father == null)
        {
            father.gameObject.SetActive(false);
        }
        else
        {
            father.gameObject.SetActive(true);
            currentLocation.father.son = currentLocation;
        }

        if (currentLocation.son == null)
        {
            son.gameObject.SetActive(false);
        }
        else
        {
            son.gameObject.SetActive(true);
            currentLocation.son.father = currentLocation;
        }

        if (currentLocation.husband == null)
        {
            husband.gameObject.SetActive(false);
        }
        else
        {
            husband.gameObject.SetActive(true);
            currentLocation.husband.wife = currentLocation;
        }

        if (currentLocation.wife == null)
        {
            wife.gameObject.SetActive(false);
        }
        else
        {
            wife.gameObject.SetActive(true);
            currentLocation.wife.husband = currentLocation;
        }
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
           case 0: //NORTH
               currentLocation = currentLocation.father;
               break;
           case 1:
               currentLocation = currentLocation.son;
               break;
           case 2:
               currentLocation = currentLocation.husband;
               break;
           case 3:
               currentLocation = currentLocation.wife;
               break;
        }
        
        UpdateLocation();
    }
}
