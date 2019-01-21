using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_pressurizationDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_pressurizationDataRefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_pressurization_actuatorsDataRefs(data);
            indicators = new sim_cockpit2_pressurization_indicatorsDataRefs(data);
        }
        public sim_cockpit2_pressurization_actuatorsDataRefs actuators { get; }
        public sim_cockpit2_pressurization_indicatorsDataRefs indicators { get; }
    }
}