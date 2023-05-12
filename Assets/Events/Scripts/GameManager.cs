using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Player.onTouched += ConsoleMessage;
        Player.onTouched1 += ConsoleMessage1;
        Player.onTouched2 += ConsoleMessage2;
        EventBus.onTest += ConsoleMessageTest;
    }

    private void OnDisable()
    {
        Player.onTouched -= ConsoleMessage;
        Player.onTouched1 -= ConsoleMessage1;
        Player.onTouched2 -= ConsoleMessage2;
        EventBus.onTest -= ConsoleMessageTest;
    }
    private void ConsoleMessage()
    {
        Debug.Log("Cube bumped");
    }

    private void ConsoleMessage1(string messege)
    {
        Debug.Log($"Cube {messege}");
    }

    private string ConsoleMessage2(string messege)
    {
        Debug.Log($"Cube {messege}");
        return messege + " func";
    }

    private void ConsoleMessageTest()
    {
        Debug.Log("Cube bumped, test succesfull");
    }
}
