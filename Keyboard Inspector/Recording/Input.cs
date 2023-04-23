﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Keyboard_Inspector {
    class KeyInput: Input<Keys> {
        public KeyInput(Keys k): base(k) {}

        public override string Source => "Keyboard";

        public override Color DefaultColor => Color.DarkGray;

        protected override char BinaryID => 'k';

        public static KeyInput FromBinaryDerived(BinaryReader br, uint fileVersion) {
            return new KeyInput((Keys)br.ReadInt32());
        }
    }

    enum GamepadKeys {
         Button1,  Button2,  Button3,  Button4,  Button5,  Button6,  Button7,  Button8,
         Button9, Button10, Button11, Button12, Button13, Button14, Button15, Button16,
        Button17, Button18, Button19, Button20, Button21, Button22, Button23, Button24,
        Button25, Button26, Button27, Button28, Button29, Button30, Button31, Button32,
        HatN, HatE, HatS, HatW
    }

    class GamepadInput: Input<GamepadKeys> {
        public GamepadInput(GamepadKeys k): base(k) {}

        public override string Source => "Gamepad";

        public override Color DefaultColor => Color.DarkGray;

        protected override char BinaryID => 'g';

        public static GamepadInput FromBinaryDerived(BinaryReader br, uint fileVersion) {
            return new GamepadInput((GamepadKeys)br.ReadInt32());
        }
    }
}
