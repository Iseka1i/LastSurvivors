using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    public Weapon.CombatController combatController;
    public TextMeshProUGUI ammosText;

    public void Update()
    {
        ammosText.text = combatController.weapon.currentAmmos + "/" + combatController.weapon.maxAmmos + " - " + combatController.weapon.caliber;
    }
}
