using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuadroDialogo : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;
    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && hasTalked == false)
        {
            NextFrase();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "NPC3")
        {
            frasesDialogo = other.gameObject.GetComponent<CUADROBehaviour>().Data.dialogueCUADRO;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "La contraseña es el nombre del director de TIC";
            }

            else
            {
                textoDelDialogo.text = "La contraseña es el nombre del director de TIC";
            }
        }
    }
    void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }

    }
}
