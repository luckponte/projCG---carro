using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LimiteVelocidade : MonoBehaviour {
    public float limite;
    public GameObject carro;

    public static int pontocarteira = 21;
    private Rigidbody fisicaCarro;
    private float velocidadeatual;
    private int jaLevou;

    public static GameObject pontoscarteira;
    private Text pontosDisplay;

    void OnTriggerStay(Collider trecho)
    {
        velocidadeatual = trecho.rigidbody.velocity.magnitude*2.23693629f;

        if (velocidadeatual>limite)
        {
            if ((velocidadeatual > (limite + (limite * .50))) && (jaLevou==2))
            {
                pontocarteira -= 7;
                jaLevou = 3;
            }
            else
            {
                if ((velocidadeatual > (limite + (limite * .20)) && velocidadeatual < (limite * (limite * .50))) && (jaLevou==1))
                {    
                    pontocarteira -= 5;
                    jaLevou = 2;
                }
                else
                {
                    if(jaLevou==0)
                    {    
                        pontocarteira -= 4;
                        jaLevou=1;
                    }
                }
            }   
            
            pontosDisplay.text = "Pontos restantes na carteira: \n" + pontocarteira;
        }


        /*if (!jaLevou) {
            velocidadeatual = fisicaCarro.velocity.magnitude*2.23693629f;
            if(velocidadeatual > limite)
            {
                if (velocidadeatual > (limite + (limite * .20)) && velocidadeatual < (limite * (limite * .50)))
                {
                    pontocarteira -= 5;
                    jaLevou = true;
                }
                if (velocidadeatual > (limite + (limite * .50)))
                {
                    pontocarteira -= 7;
                    jaLevou = true;
                }
                else;
                pontocarteira -= 4;
                jaLevou = true;
            }
            //int number = (int)pontocarteira;
            pontosDisplay.text = "Pontos restantes na carteira: \n" + pontocarteira;
        }*/
    }
    void OnTriggerExit( Collider trecho)
    {
        if (jaLevou!=0)
            jaLevou = 0;
    }

    	// Use this for initialization
	void Start () {
        jaLevou = 0;
        pontocarteira = 21;
        pontosDisplay = pontoscarteira.GetComponent<Text>();
        fisicaCarro = carro.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
