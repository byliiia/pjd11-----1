using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{ private int numero;
    public float velocidade = 40;
    void Start()
    {
    numero = 0;
    }
    
    void Update()
    {
    //Debyg.Log(numero);
    //numero * numero * 1
    