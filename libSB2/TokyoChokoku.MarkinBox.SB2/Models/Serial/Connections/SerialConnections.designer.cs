﻿﻿// 
// This code is generated by "MutableParameterTemplate.tt"
// Not allowed to modify this code because your changes are deleted when in regeration.
// 

namespace TokyoChokoku.MarkinBox.Sketchbook.Properties.Stores {
    using TokyoChokoku.MarkinBox.Sketchbook.Properties;
    using TokyoChokoku.MarkinBox.Sketchbook.Validators;
    using TokyoChokoku.MarkinBox.Sketchbook.Connections;
    using System.Linq;
    using System.Collections.Generic;

    public class SerialSettingsFormatConnection : Connection<short>
    {
        public SerialSettingsFormatConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.FormatStore,
            short.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsClearingConditionConnection : Connection<short>
    {
        public SerialSettingsClearingConditionConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.ClearingConditionStore,
            short.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsMaxValueConnection : Connection<int>
    {
        public SerialSettingsMaxValueConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.MaxValueStore,
            int.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsMinValueConnection : Connection<int>
    {
        public SerialSettingsMinValueConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.MinValueStore,
            int.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsRepeatingCountConnection : Connection<byte>
    {
        public SerialSettingsRepeatingCountConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.RepeatingCountStore,
            byte.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsClearingTimeHHConnection : Connection<short>
    {
        public SerialSettingsClearingTimeHHConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.ClearingTimeHHStore,
            short.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsClearingTimeMMConnection : Connection<short>
    {
        public SerialSettingsClearingTimeMMConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.ClearingTimeMMStore,
            short.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }

    public class SerialSettingsCounterSerialNoConnection : Connection<short>
    {
        public SerialSettingsCounterSerialNoConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.CounterSerialNoStore,
            short.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }
    public class SerialSettingsCounterCurrentValueConnection : Connection<int>
    {
        public SerialSettingsCounterCurrentValueConnection(
            SerialStores stores,
            ModificationListener errorListener,
            ModificationListener modifiedListener
        ) : base (
            stores.CounterCurrentValueStore,
            int.TryParse,
            errorListener,
            modifiedListener
        )
        {
        }
    }

}
