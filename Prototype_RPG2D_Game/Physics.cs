using UnityEngine;
using System.Collections;

   public class Physics : MonoBehaviour
    {

        void Start()
        {
        }
        void Update()
        {

        }


        public int setRotateUnder360(int rotate)
        {
            while (rotate > 360)
                rotate -= 360;

            return rotate;
        }

        public float setSpeedXInCreate(int rotate, float speed)
        {
          float speedX = 0;

          if (rotate == 0 || rotate == 180) 
          {
            //speedX = 0;
          }
          else if (rotate == 45 || rotate == 135) 
          {
            speedX = -speed / 2;
          }
          else if (rotate == 90) 
          {
            speedX = -speed;
          }
          else if (rotate == 225 || rotate == 315) 
          {
            speedX = speed / 2;
          }
          else if (rotate == 270) 
          {
            speedX = speed;
          }
          return speedX;
        }

        public float setSpeedYInCreate(int rotate, float speed)
        {
            float speedY = 0;

            if (rotate == 0) //0
            {
                speedY = speed;
            }
            else if (rotate == 45 || rotate == 315)
            {
                speedY = speed / 2;
            }
            else if (rotate == 90 || rotate == 270)
            {
               //speedY = 0;
            }
            else if (rotate == 135 || rotate == 225) 
            {
                speedY = -speed / 2;
            }
            else if (rotate == 180) 
            {
                speedY = -speed;
            }
        return speedY;
        }

    }

