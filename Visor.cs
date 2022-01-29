using MelonLoader;
using UnityEngine;
using EFT;

namespace JET_NoVisor
{
    public class Visor : MelonMod
    {

        private Camera _localCamera { get; set; }


        public override void OnUpdate()
        {
            base.OnUpdate();
            _updateCamera();
            if (_localCamera == null)
                return;

            _localCamera.GetComponent<VisorEffect>().Intensity = 0f;
        }

        private void _updateCamera() 
        {
            _localCamera = Camera.main;
        }

    }
}
