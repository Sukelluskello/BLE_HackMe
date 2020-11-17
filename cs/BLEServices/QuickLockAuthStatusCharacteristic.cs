﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Security.Cryptography;

namespace BLE_Hackme.BLEServices
{
    public class QuickLockAuthStatusCharacteristic : GenericGattCharacteristic
    {
        public QuickLockAuthStatusCharacteristic(GattLocalCharacteristic characteristic, GenericGattService service) : base(characteristic, service)
        {

            Value = BLEServices.Helpers.ToIBuffer((byte)0);
        }

        // the value is updated from the QuickLockAuthCharacteristic

    }
}
