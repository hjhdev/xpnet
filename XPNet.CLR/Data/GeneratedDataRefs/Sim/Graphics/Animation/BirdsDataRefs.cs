using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animation_birdsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animation_birdsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  degree of wing flap for the currently drawn bird. Units:float
        ///  Raw path: sim/graphics/animation/birds/wing_flap_deg
        /// </summary>
        public IXPDataRef<float> wing_flap_deg { get { return m_data.GetFloat("sim/graphics/animation/birds/wing_flap_deg");} }

        /// <summary>
        ///  angle the bird's feet are retracted for the flock of birds.. Units:float
        ///  Raw path: sim/graphics/animation/birds/feet_retract_deg
        /// </summary>
        public IXPDataRef<float> feet_retract_deg { get { return m_data.GetFloat("sim/graphics/animation/birds/feet_retract_deg");} }
    }
}