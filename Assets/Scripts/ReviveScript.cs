using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveScript : MonoBehaviour {
    public GameObject PrefabPlayer;

	// Update is called once per frame
	void Update () {
		if(!GameObject.Find("SJ001_run"))
        {
            GameObject Player = Instantiate<GameObject>(PrefabPlayer);
        }
	}
}
