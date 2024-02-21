using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour {

    public float Velocidade = 10;
    Vector3 direcao;
    // Update is called once per frame
    void Update() {

        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);

        if(direcao != Vector3.zero){
            GetComponent<Animator>().SetBool("Movendo", true);
        }else{
            GetComponent<Animator>().SetBool("Movendo", false);
        }
    }
    //roda por tempo
    void FixedUpdate() {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + (direcao * Velocidade * Time.deltaTime));  
    }
}
