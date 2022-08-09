using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gamemaster : MonoBehaviour
{
    public Transform obj1;
    public Transform obj2;

    public TMP_Text text;
    public Camera camera;
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Mathf.Sqrt(Mathf.Pow((obj2.position.x - obj1.position.x),2) + Mathf.Pow((obj2.position.y - obj1.position.y), 2));
        if (distance <= 1)
        {
            points++;
            obj2.GetComponent<square_logic>().respawn();
            text.text = "Punkte: " + points;
        }
    }
}
