using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourController : MonoBehaviour
{
    [SerializeField] PlayfabManager playfabManager;
    static MeshFilter playerMesh;
    [SerializeField] Mesh red;
    [SerializeField] Mesh blue;
    [SerializeField] Mesh yellow;

    public string chosenColour;



    private void Start()
    {
        playerMesh = GetComponent<MeshFilter>();    
    }


    public void RedSelected()
    {
        playerMesh.mesh = red;
        chosenColour = "Red";
        playfabManager.SaveMesh();
    }

    public void BlueSelected()
    {
        playerMesh.mesh = blue;
        chosenColour = "Blue";
        playfabManager.SaveMesh();
    }

    public void YellowSelected()
    {
        playerMesh.mesh = yellow;
        chosenColour = "Yellow";
        playfabManager.SaveMesh();
    }


}
