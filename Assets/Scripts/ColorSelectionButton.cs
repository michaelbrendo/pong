using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPlayer = false;

    public void OnButtonClick()
    {
        //paddleReference.color = uiButton.colors.normalColor;
        Color selectedColor = uiButton.GetComponent<Image>().color;
        paddleReference.color = selectedColor;

        if (isColorPlayer)
        {
            SaveController.Instance.colorPlayer = paddleReference.color;
        }
        else
        {
            SaveController.Instance.colorEnemy = paddleReference.color;
        }

        // Update paddle colors immediately
        UpdatePaddleColors();

    }

    private void UpdatePaddleColors()
    {
        var enemyController = FindObjectOfType<EnemyController>();
        if (enemyController != null)
        {
            enemyController.UpdatePaddleColors();
        }
    }

}
