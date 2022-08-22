using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Weapon.models
{
    class Weapons
    {
        private int _magazineCapacity;
        private int _numberOfBulletsRemaining;
        private float _dischargeSecond;
        private string _fireMode;
        public int MagazineCapacity {
            get
            {
                return _magazineCapacity;
            }

            set
            {
                if (value>=0)
                {
                    _magazineCapacity = value;
                }
            }
         }
        public int NumberOfBulletsRemaining {
            get
            {
                return _numberOfBulletsRemaining;
            }
            set
            {
                if (value>=0 && value<=MagazineCapacity)
                {
                    _numberOfBulletsRemaining = value;
                }
            }
        }
        public float DischargeSecond {
            get 
            {
                return _dischargeSecond;
            }
            set
            {
                if (value>0)
                {
                    _dischargeSecond = value;
                }
            }
        }
        public string FireMode {
            get
            {
                return _fireMode;
            }
            set 


            {
                if (value=="Single"||value=="Automatic")
                {
                    _fireMode = value;
                }
            }
         } 
        public void GetInfo()
        {
            Console.WriteLine("MagazineCapacity:" + MagazineCapacity + "\nNumberOfBulletsRemaining:" + NumberOfBulletsRemaining + "\nDischargeSecond:" + DischargeSecond + "\nFireMode:" + FireMode);
        }
        public void Shoot()
        {
            if (NumberOfBulletsRemaining>0)
            {
                NumberOfBulletsRemaining--;

                Console.WriteLine("Shoot a Bullet"); 
                if (NumberOfBulletsRemaining==0)
                {
                    Console.WriteLine("Bullet Over"); 
                }
            }
            else
            {
                Reload();
            }
          
        }
        public void Fire()
        {
            
            if (NumberOfBulletsRemaining > 0)
            {
               float time = DischargeSecond / (NumberOfBulletsRemaining * MagazineCapacity);
                Console.WriteLine(time);
            }
            else
            {
                Reload();
            }
           
        }
        public int GetRemainBulletCount()
        {
            int count = MagazineCapacity - NumberOfBulletsRemaining;
            return count;
            
            
        }
        public void Reload()
        {
            if (NumberOfBulletsRemaining == MagazineCapacity)
            {
                Console.WriteLine("You can't reload");
                return;
            }
            
            Console.WriteLine("Reloading...");
            Thread.Sleep(4000);
             NumberOfBulletsRemaining= MagazineCapacity;
            Console.WriteLine("Reloaded");
           

        }
        public void ChangeFireMode()
        {
            if (FireMode=="Single")
            {
                FireMode = "Automatic";

            }
            else if (FireMode=="Automatic")
            {
                FireMode = "Single";

            }
         
            
        }
        public Weapons(int magazineCapacity, int numberOfBulletsRemaining, float dischargeSecond, string fireMode)
        {
           MagazineCapacity = magazineCapacity;
            NumberOfBulletsRemaining = numberOfBulletsRemaining;
            DischargeSecond = dischargeSecond;
            FireMode = fireMode;

        }


    }
}
