using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ejercicio01 : MonoBehaviour
{
    //ZONA DE VARIABLES
    [SerializeField] Button botonMultiplicar;
    [SerializeField] Button botonDividir;
    [SerializeField] Button botonSumar;
    [SerializeField] Button botonRestar;
    [SerializeField] Button continuar;

    [SerializeField] TMP_InputField input_a;
    [SerializeField] TMP_InputField input_b;

    [SerializeField] GameObject insertarValores;
    [SerializeField] GameObject operaciones;

    private float usuario_a;
    private float usuario_b;

    private void Start()
    {
        insertarValores.SetActive(true);
        continuar.onClick.AddListener(delegate { DesactivarValores(); });
        botonMultiplicar.onClick.AddListener(delegate { Multiplicar(usuario_a,usuario_b); });
        botonDividir.onClick.AddListener(delegate { Dividir(usuario_a, usuario_b); });
        botonSumar.onClick.AddListener(delegate { Sumar(usuario_a, usuario_b); });
        botonRestar.onClick.AddListener(delegate { Restar(usuario_a, usuario_b); });
    }

    /// <summary>
    /// Nuestras funciones
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// 
    private void DesactivarValores()
    {
        insertarValores.SetActive(false);
        operaciones.SetActive(true);

    }

    private void Dividir(float a, float b)
    {
        float resultado = 0;
        resultado = a / b;
        Debug.Log(resultado);
    }

    private void Multiplicar(float a, float b)
    {
        float resultado = 0;
        resultado = a * b;
        Debug.Log(resultado);
    }

    private void Sumar(float a, float b)
    {
        float resultado = 0;
        resultado = a + b;
        Debug.Log(resultado);
    }

    private void Restar(float a, float b)
    {
        float resultado = 0;
        resultado = a - b;
        Debug.Log(resultado);
    }

    public void ActualizarNumero_A()
    {
        usuario_a = float.Parse(input_a.text);
    }

    public void ActualizarNumero_B()
    {
        usuario_b = float.Parse(input_a.text);
    }
}   

