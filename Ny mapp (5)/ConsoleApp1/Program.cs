public class SMG
{
    public string Name;

    public int FireRate;

    public interface Damage;

    public int Ammo;
    public int MaxAmmo;


    public void Fire(Character target)
    {
        target.Hp -= Damage;
    }
    public void Inspect()


     public void AimDownSight()
     
     public void Reload()
}