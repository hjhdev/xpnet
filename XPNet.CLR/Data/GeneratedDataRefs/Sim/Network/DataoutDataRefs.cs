using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_network_dataoutDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_network_dataoutDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Rate to send data over UDP at. Units:hz
        ///  Raw path: sim/network/dataout/network_data_rate
        /// </summary>
        public IXPDataRef<int> network_data_rate { get { return m_data.GetInt("sim/network/dataout/network_data_rate");} }

        /// <summary>
        ///  Enable data output of this data ref to internet. Units:boolean
        ///  Raw path: sim/network/dataout/data_to_internet
        /// </summary>
        public IXPDataRef<bool[]> data_to_internet { get { return m_data.GetBoolArray("sim/network/dataout/data_to_internet");} }

        /// <summary>
        ///  Enable data output of this data ref to disk file. Units:boolean
        ///  Raw path: sim/network/dataout/data_to_disk
        /// </summary>
        public IXPDataRef<bool[]> data_to_disk { get { return m_data.GetBoolArray("sim/network/dataout/data_to_disk");} }

        /// <summary>
        ///  Enable data output of this data ref to graph. Units:boolean
        ///  Raw path: sim/network/dataout/data_to_graph
        /// </summary>
        public IXPDataRef<bool[]> data_to_graph { get { return m_data.GetBoolArray("sim/network/dataout/data_to_graph");} }

        /// <summary>
        ///  Enable data output of this data ref to screen. Units:boolean
        ///  Raw path: sim/network/dataout/data_to_screen
        /// </summary>
        public IXPDataRef<bool[]> data_to_screen { get { return m_data.GetBoolArray("sim/network/dataout/data_to_screen");} }

        /// <summary>
        ///  Dump extra prop data to screen. Units:boolean
        ///  Raw path: sim/network/dataout/dump_parts_props
        /// </summary>
        public IXPDataRef<bool> dump_parts_props { get { return m_data.GetBool("sim/network/dataout/dump_parts_props");} }

        /// <summary>
        ///  Dump wing prop data to screen. Units:boolean
        ///  Raw path: sim/network/dataout/dump_parts_wings
        /// </summary>
        public IXPDataRef<bool> dump_parts_wings { get { return m_data.GetBool("sim/network/dataout/dump_parts_wings");} }

        /// <summary>
        ///  Dump vertical stabilizer prop data to screen. Units:boolean
        ///  Raw path: sim/network/dataout/dump_parts_vstabs
        /// </summary>
        public IXPDataRef<bool> dump_parts_vstabs { get { return m_data.GetBool("sim/network/dataout/dump_parts_vstabs");} }

        /// <summary>
        ///  Is this machine running as an external visual for another X-Plane machine.. Units:boolean
        ///  Raw path: sim/network/dataout/is_external_visual
        /// </summary>
        public IXPDataRef<bool> is_external_visual { get { return m_data.GetBool("sim/network/dataout/is_external_visual");} }

        /// <summary>
        ///  Is this machine part of an x-plane built-in multiplayer session?. Units:boolean
        ///  Raw path: sim/network/dataout/is_multiplayer_session
        /// </summary>
        public IXPDataRef<bool> is_multiplayer_session { get { return m_data.GetBool("sim/network/dataout/is_multiplayer_session");} }

        /// <summary>
        ///  Is this machine running in instructor-station mode?. Units:boolean
        ///  Raw path: sim/network/dataout/is_instructor_station
        /// </summary>
        public IXPDataRef<bool> is_instructor_station { get { return m_data.GetBool("sim/network/dataout/is_instructor_station");} }

        /// <summary>
        ///  IP addresses of multiplayer players (or 0 if not in used in v10). Units:ip
        ///  Raw path: sim/network/dataout/multiplayer_ip
        /// </summary>
        public IXPDataRef<int[]> multiplayer_ip { get { return m_data.GetIntArray("sim/network/dataout/multiplayer_ip");} }

        /// <summary>
        ///  IP addresses of external visuals (or 0 if not in use in v10).  Dim 8 in v9.. Units:ip
        ///  Raw path: sim/network/dataout/external_visual_ip
        /// </summary>
        public IXPDataRef<int[]> external_visual_ip { get { return m_data.GetIntArray("sim/network/dataout/external_visual_ip");} }

        /// <summary>
        ///  True if this remote visual tracks the master's view changes. Units:boolean
        ///  Raw path: sim/network/dataout/track_external_visual
        /// </summary>
        public IXPDataRef<bool[]> track_external_visual { get { return m_data.GetBoolArray("sim/network/dataout/track_external_visual");} }
    }
}