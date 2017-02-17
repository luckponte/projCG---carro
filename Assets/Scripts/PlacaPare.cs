using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlacaPare : MonoBehaviour {
    public GameObject carro;

    private int pontocarteira;
    private Rigidbody fisicaCarro;
    private float velocidadeatual;
    private bool jaParou;

    public GameObject pontoscarteira;
    private Text pontosDisplay;

    void OnTriggerStay(Collider trecho)
    {
            velocidadeatual = fisicaCarro.velocity.magnitude * 2.23693629f;
            if (velocidadeatual <= 0)
            {
                jaParou = true;
            }
            
    }
    void OnTriggerExit(Collider trecho)
    {
        if (!jaParou)
        {
            pontocarteira -= 7;
            pontosDisplay.text = "Pontos restantes na carteira: \n" + pontocarteira;
        }
    }

    // Use this for initialization
    void Start()
    {
        jaParou = false;
        pontocarteira = 21;
        pontosDisplay = pontoscarteira.GetComponent<Text>();
        fisicaCarro = carro.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
