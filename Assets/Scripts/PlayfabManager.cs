using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;



public class PlayfabManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Login();        
    }

    void Login () {
        var request = new LoginWithCustomIDRequest {
            CustomId = SystemInfo.deviceUniqueIdentifier, 
            CreateAccount = true
        };

        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError );
    }
   

    void OnSuccess (LoginResult result ) {
        Debug.Log("successfull login created ");
    }

    void OnError (PlayFabError error) {
        Debug.Log("Error in login  ");
        Debug.Log(error.GenerateErrorReport() );

    }
   
}
