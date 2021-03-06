using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedSystemsTest.SensorNetwork
{
    public enum SensorItemEnum
    {
        // general
        GATE,
        PROXIMITY,
        AZIMUTH_MOTOR,
        ELEVATION_MOTOR,
        WEATHER_STATION,

        // specific
        AZ_MOTOR_TEMP,
        ELEV_MOTOR_TEMP,
        AZ_MOTOR_VIBRATION,
        ELEV_MOTOR_VIBRATION,
        AZ_MOTOR_CURRENT,
        ELEV_MOTOR_CURRENT,
        COUNTER_BALANCE_VIBRATION,
        WIND,
        RAIN_AMOUNT
    }
}
