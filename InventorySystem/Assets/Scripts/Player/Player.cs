﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            ChestPanel.Instance.SwitchPanelDisplayStatus();
        }
        if (Input.GetKeyDown(KeyCode.K)) {
            KnapsackPanel.Instance.SwitchPanelDisplayStatus();
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            RolePanel.Instance.SwitchPanelDisplayStatus();
        }

        if (Input.GetKeyDown(KeyCode.G)) {
            int id = Random.Range(1, 15);
            KnapsackPanel.Instance.StoreItem(id);
        }

    }
}
