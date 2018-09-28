using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IBMWIoTP;

namespace IoTVirtualClient.Helpers
{
    public class IbmConnectionManagement
    {
        public static void DeviceClient(string status)
        {
            var orgId = "0vv3hx";
            var authToken = "?IOp7v6Zkt_jUmA9+?";
            var deviceType = "raspberrypi3";
            var deviceId = "sensehat";

            DeviceClient deviceClient = new DeviceClient(orgId, deviceType, deviceId, "token", authToken);
            deviceClient.connect();
            var data = "{ \"device\": \"heater\", \"status\": \"" + status + "\"}";
            deviceClient.publishEvent("switch", "json", data);
        }
    }
}