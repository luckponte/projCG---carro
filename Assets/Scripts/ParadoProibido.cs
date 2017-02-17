using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParadoProibido : MonoBehaviour {
    public GameObject carro;

    private int pontocarteira;
    private Rigidbody fisicaCarro;
    private float velocidadeatual;
    private bool jaLevou;

    public GameObject pontoscarteira;
    private Text pontosDisplay;

    void OnTriggerStay(Collider trecho)
    {
        if (!jaLevou)
        {
            velocidadeatual = fisicaCarro.velocity.magnitude * 2.23693629f;
            if (velocidadeatual <= 0 )
            {
                pontocarteira -= 4;
                jaLevou = true;
            }
            //int number = (int)pontocarteira;
            pontosDisplay.text = "Pontos restantes na carteira: \n" + pontocarteira;
        }
    }
    void OnTriggerExit(Collider trecho)
    {
        if (!jaLevou)
            jaLevou = false;
    }

    // Use this for initialization
    void Start () {
        jaLevou = false;
        pontocarteira = 21;
        pontosDisplay = pontoscarteira.GetComponent<Text>();
        fisicaCarro = carro.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
