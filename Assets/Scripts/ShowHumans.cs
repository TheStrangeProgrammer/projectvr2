using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHumans : MonoBehaviour
{
    bool toggle = true;
    GameObject[] humans;
    // Start is called before the first frame update
    void Start()
    {
        humans=GameObject.FindGameObjectsWithTag("humans");
        ToggleHumansInGame();
    }
    public void ToggleHumansInGame()
    {
        toggle = !toggle;
        foreach (GameObject human in humans)
        {
            human.SetActive(toggle);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ToggleHumansInGame();
        }
    }
}
