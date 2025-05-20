interface IAttackable
{
    int Health { get; }

    void TakeDamage(int amount);

    void Heal(int amount);
}