using System;
/// <summary>
/// class player 
/// </summary>

    class Player
    {
        string name;
        float maxHp;
        float hp;

        public Player(string name = "Player", float maxHp= 100f)
        {
            this.name = name;
            if (maxHp <= 0){
                maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = maxHp;
            this.maxHp = maxHp;
        }

        public void PrintHealth()
        {
            Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
        }
    

    public void TakeDamage(float damage)
        {
            if (damage < 0)
            {
                damage = 0;
            }
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            hp-=damage;
        }

    public void HealDamage(float heal)
        {
            if (heal < 0)
            {
                heal = 0;
            }
            Console.WriteLine("{0} heals {1} damage!", this.name, heal);
            hp+= heal;
        }
    public delegate void CalculateHealth(float damage);
    }


