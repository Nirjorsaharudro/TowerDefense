using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    void Start() {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandardTurret(){
        Debug.Log("Standard turret selected");
        buildManager.SetTurretToBuild(buildManager.standaredTurretPrefab);
    }
    
    public void PurchaseMissileLaunchar(){
        Debug.Log("Missile Launchar selected");
        buildManager.SetTurretToBuild(buildManager.MissileLauncherPrefab);
    }
}
