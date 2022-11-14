using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    public class Client : TimerClient
    {
        public Recipe Receta;
        public Client(Recipe r)
        {
            this.Receta = r;      
        }
        public void TimeOut()
        {
            this.Receta.SetCooked();
        }
    }
}