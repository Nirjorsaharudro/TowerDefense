using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLaunchar;
    public TurretBlueprint leaserBeamer;
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

      public void SelectLeaserBeamer(){
        Debug.Log("Leaser Beamer selected");
        buildManager.SelectTurretToBuild(leaserBeamer);
    }
}
