using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITest : MonoBehaviour
{
    string textAreaString = "text area";
    private string textFieldString = "text field";
    private Rect windowRect = new Rect (20, 20, 120, 50);
    public GUIStyle custom;
    void OnGUI()
    {
        /*
        // Make a background box
        GUI.Box(new Rect(10,10,100,90), "Loader Menu");
    
        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if(GUI.Button(new Rect(20,40,80,20), "Level 1"))
        {
            Application.LoadLevel(0);
        }
    
        // Make the second button.
        if(GUI.Button(new Rect(20,70,80,20), "Level 2")) 
        {
            Application.LoadLevel(1);
        }
        
        //Flashing Button
        if (Time.time % 2 < 1) 
        {
            if (GUI.Button (new Rect (10,110,200,20), "Meet the flashing button"))
            {
                print ("You clicked me!");
            }
        }
    */
        // This line feeds "This is the tooltip" into GUI.tooltip
        GUI.Button(new Rect(10, 10, 100, 20), new GUIContent("Click me", "This is the tooltip"),custom);

        // This line reads and displays the contents of GUI.tooltip
        GUI.Label(new Rect(10, 40, 100, 20), GUI.tooltip, custom);
        
        textFieldString = GUI.TextField (new Rect (25, 100, 100, 30), textFieldString);
        
        textAreaString = GUI.TextArea(new Rect(25, 150, 100, 30), textAreaString);
        
        windowRect = GUI.Window (0, windowRect, WindowFunction, "My Window");
    }
    
    void WindowFunction (int windowID) 
    {
        // Draw any Controls inside the window here
    }

}
