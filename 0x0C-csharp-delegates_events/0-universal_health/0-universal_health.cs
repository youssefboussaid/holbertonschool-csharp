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
                this.maxHp = 100f;
                Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            }
            this.hp = maxHp;
            this.maxHp = maxHp;
        }

        public void PrintHealth()
        {
            Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
        }
    }
