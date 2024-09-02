using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository
{
    public class GlobalStateManager
    {
        private static GlobalStateManager? _instance;
        private bool _isKeyboard;

        public event Action<bool>? OnModeChanged;

        private GlobalStateManager()
        {
            _isKeyboard = true;
        }

        public static GlobalStateManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalStateManager();
                }
                return _instance;
            }
        }

        public bool IsKeyboard
        {
            get => _isKeyboard;
            set
            {
                if (_isKeyboard != value)
                {
                    _isKeyboard = value;
                    OnModeChanged?.Invoke(_isKeyboard);
                }
            }
        }
    }

}
