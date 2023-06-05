using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]

public class Posizione : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI text;

    private Dictionary<string, string> lookup_table;
    private void Start()
    {
        lookup_table = new Dictionary<string, string>() {
            {"sud_america", "Sud America" },
            {"nord_america", "Nord America" },
            {"africa", "Africa" },
            {"europa", "Europa" },
            {"asia", "Asia" },
            {"oceania", "Oceania" },
            {"oceano_atlantico", "Oceano Atlantico" },
            {"oceano_pacifico", "Oceano Pacifico" },
            {"oceano_indiano", "Oceano Indiano" },
            {"oceano_pacifico2", "Oceano Pacifico" }
        };
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        text.text = lookup_table[other.gameObject.name];
    }
}
