using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoPecera : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.L) && hasTalked == false)
        {
            NextFrase();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "NPC2")
        {
            frasesDialogo = other.gameObject.GetComponent<PEZBehaviour>().Data.dialoguePEZ;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "La contraseña esta en el cuadro de Marissa Mayer";
            }

            else
            {
                textoDelDialogo.text = "La contraseña esta en el cuadro de Marissa Mayer";
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
