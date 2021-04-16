using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLaunchar;
    BuildManager buildManager;
    void Start() {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret(){
        Debug.Log("Standard turret selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }
    
    public void SelectMissileLaunchar(){
        Debug.Log("Missile Launchar selected");
        buildManager.SelectTurretToBuild(missileLaunchar);
    }
}
