using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    public class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
       


        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name,int currSp) {
            CurrentSpeed = currSp;
            PetName = name;
          
        }

        public void CrankTunes(bool state) {
            theMusicBox.TurnOn(state);
        }


        

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine("{0} is out of order....", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;

                    Exception ex = new Exception(string.Format("{0} has overheated!", PetName));

                    throw ex;


                }
                else
                {
                    Console.WriteLine("=> CurrentSpeed={0}", CurrentSpeed);
                }
            }
            } 

        



    }
}
