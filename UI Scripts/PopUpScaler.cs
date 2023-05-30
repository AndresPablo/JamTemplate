using System.Collections;
using UnityEngine;

public class PopUpScaler : MonoBehaviour
{
    public Transform popUpTransform; // Referencia al transform del pop-up
    public float scaleSpeed = 5f; // Velocidad de escalado del pop-up

    private Vector3 initialScale; // Escala inicial del pop-up
    private Coroutine currentScaleCoroutine; // Referencia a la corutina de escalado actual

    private void Start()
    {
        // Almacenar la escala inicial del pop-up
        initialScale = popUpTransform.localScale;
        // Ponemos el tam en 0 para que empiece escondido
        popUpTransform.localScale = Vector3.zero;
    }

    public void ShowPopUp()
    {
        // Detener cualquier corutina de escalado actual
        if (currentScaleCoroutine != null)
        {
            StopCoroutine(currentScaleCoroutine);
        }

        // Iniciar la corutina de escalado hacia la escala original
        currentScaleCoroutine = StartCoroutine(ScalePopUp(popUpTransform.localScale, initialScale));
    }

    public void HideFast()
    {
        popUpTransform.localScale = new Vector3(0,0,0);
    }

    public void HidePopUp()
    {
        // Detener cualquier corutina de escalado actual
        if (currentScaleCoroutine != null)
        {
            StopCoroutine(currentScaleCoroutine);
        }

        // Iniciar la corutina de escalado hacia 0
        currentScaleCoroutine = StartCoroutine(ScalePopUp(popUpTransform.localScale, Vector3.zero));
    }

    private IEnumerator ScalePopUp(Vector3 startScale, Vector3 targetScale)
    {
        float elapsedTime = 0f;

        while (elapsedTime < 1f)
        {
            elapsedTime += Time.deltaTime * scaleSpeed;

            // Escalar el pop-up interpolando entre la escala inicial y la escala objetivo
            popUpTransform.localScale = Vector3.Lerp(startScale, targetScale, elapsedTime);

            yield return null;
        }

        // Asegurarse de establecer la escala final para evitar posibles errores de interpolación
        popUpTransform.localScale = targetScale;

        // Limpiar la referencia a la corutina actual
        currentScaleCoroutine = null;
    }
}
