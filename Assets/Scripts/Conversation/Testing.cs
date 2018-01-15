using RPG.Conversations;
using UnityEngine;
using System;
using Newtonsoft.Json;

public class Testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ConversationSpeaker speaker = new ConversationSpeaker();
        speaker.Id = Guid.NewGuid();
        speaker.Name = "Garret";

        string json = JsonConvert.SerializeObject( speaker );
        UnityEngine.Debug.LogError( json );
	}
}
