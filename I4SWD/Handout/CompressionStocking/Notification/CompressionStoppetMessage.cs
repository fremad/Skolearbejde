using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking.Notification
{
   public class CompressionStoppetMessage : INotify
    {
        private readonly Lights.ILight _light = new Lights.Greenlight();
        private readonly IVibrator _vibrator = new VibratorA();

        public void notify()
        {
            _light.Off();
            _vibrator.Off();
        }     
    }
}
