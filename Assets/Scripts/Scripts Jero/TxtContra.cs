﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TxtContra : MonoBehaviour
{
    string contra;

    // Start is called before the first frame update
    void Start()
    {
        contra = KeyPadPassword.password;
        GetComponent<TextMeshPro>().text = "CONTRA : " + contra;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
