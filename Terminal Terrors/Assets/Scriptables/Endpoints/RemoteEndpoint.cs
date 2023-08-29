using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[RequireComponent(typeof(Prompter))]
public class RemoteEndpoint : Endpoint
{
    //dont worry about text implementation
    Prompter prompter;
    private void Awake()
    {
        prompter = GetComponent<Prompter>();
        //ensure endpoint is not connected at start of game
        disconnect();
    }
}
