using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_joystickDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_joystickDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Do we have a joystick?. Units:boolean
        ///  Raw path: sim/joystick/has_joystick
        /// </summary>
        public IXPDataRef<bool> has_joystick { get { return m_data.GetBool("sim/joystick/has_joystick");} }

        /// <summary>
        ///  Is the mouse acting as a joystick?. Units:boolean
        ///  Raw path: sim/joystick/mouse_is_joystick
        /// </summary>
        public IXPDataRef<bool> mouse_is_joystick { get { return m_data.GetBool("sim/joystick/mouse_is_joystick");} }

        /// <summary>
        ///  Can the mouse be used to fly?  False if there is any LEGIT hardware plugged in.. Units:boolean
        ///  Raw path: sim/joystick/mouse_can_be_joystick
        /// </summary>
        public IXPDataRef<bool> mouse_can_be_joystick { get { return m_data.GetBool("sim/joystick/mouse_can_be_joystick");} }

        /// <summary>
        ///  The deflection of the joystick axis controlling pitch. Use override_joystick or override_joystick_pitch. Units:[-1..1]
        ///  Raw path: sim/joystick/yoke_pitch_ratio
        /// </summary>
        public IXPDataRef<float> yoke_pitch_ratio { get { return m_data.GetFloat("sim/joystick/yoke_pitch_ratio");} }

        /// <summary>
        ///  Legacy - this spelling error is still present for. Units:[-1..1]
        ///  Raw path: sim/joystick/yolk_pitch_ratio
        /// </summary>
        public IXPDataRef<float> yolk_pitch_ratio { get { return m_data.GetFloat("sim/joystick/yolk_pitch_ratio");} }

        /// <summary>
        ///  The deflection of the joystick axis controlling roll. Use override_joystick or override_joystick_roll. Units:[-1..1]
        ///  Raw path: sim/joystick/yoke_roll_ratio
        /// </summary>
        public IXPDataRef<float> yoke_roll_ratio { get { return m_data.GetFloat("sim/joystick/yoke_roll_ratio");} }

        /// <summary>
        ///  Legacy - this spelling error is still present for backward compatibility with older plugins.. Units:[-1..1]
        ///  Raw path: sim/joystick/yolk_roll_ratio
        /// </summary>
        public IXPDataRef<float> yolk_roll_ratio { get { return m_data.GetFloat("sim/joystick/yolk_roll_ratio");} }

        /// <summary>
        ///  The deflection of the joystick axis controlling yaw. Use override_joystick or override_joystick_heading. Units:[-1..1]
        ///  Raw path: sim/joystick/yoke_heading_ratio
        /// </summary>
        public IXPDataRef<float> yoke_heading_ratio { get { return m_data.GetFloat("sim/joystick/yoke_heading_ratio");} }

        /// <summary>
        ///  Legacy - this spelling error is still present for backward compatibility with older plugins.. Units:[-1..1]
        ///  Raw path: sim/joystick/yolk_heading_ratio
        /// </summary>
        public IXPDataRef<float> yolk_heading_ratio { get { return m_data.GetFloat("sim/joystick/yolk_heading_ratio");} }

        /// <summary>
        ///  The artificial stability input modifications for pitch. Use override_artstab. Units:[-1..1]
        ///  Raw path: sim/joystick/artstab_pitch_ratio
        /// </summary>
        public IXPDataRef<float> artstab_pitch_ratio { get { return m_data.GetFloat("sim/joystick/artstab_pitch_ratio");} }

        /// <summary>
        ///  The artificial stability input modifications for roll. Use override_artstab. Units:[-1..1]
        ///  Raw path: sim/joystick/artstab_roll_ratio
        /// </summary>
        public IXPDataRef<float> artstab_roll_ratio { get { return m_data.GetFloat("sim/joystick/artstab_roll_ratio");} }

        /// <summary>
        ///  The artificial stability input modifications for yaw. Use override_artstab. Units:[-1..1]
        ///  Raw path: sim/joystick/artstab_heading_ratio
        /// </summary>
        public IXPDataRef<float> artstab_heading_ratio { get { return m_data.GetFloat("sim/joystick/artstab_heading_ratio");} }

        /// <summary>
        ///  Servo input for pitch. Units:[-1..1]
        ///  Raw path: sim/joystick/servo_pitch_ratio
        /// </summary>
        public IXPDataRef<float> servo_pitch_ratio { get { return m_data.GetFloat("sim/joystick/servo_pitch_ratio");} }

        /// <summary>
        ///  Servo input for roll. Units:[-1..1]
        ///  Raw path: sim/joystick/servo_roll_ratio
        /// </summary>
        public IXPDataRef<float> servo_roll_ratio { get { return m_data.GetFloat("sim/joystick/servo_roll_ratio");} }

        /// <summary>
        ///  Servo input for yaw. Units:[-1..1]
        ///  Raw path: sim/joystick/servo_heading_ratio
        /// </summary>
        public IXPDataRef<float> servo_heading_ratio { get { return m_data.GetFloat("sim/joystick/servo_heading_ratio");} }

        /// <summary>
        ///  Flight Control Heading (sum of yoke plus artificial stability). Units:[-1..1]
        ///  Raw path: sim/joystick/FC_hdng
        /// </summary>
        public IXPDataRef<float> FC_hdng { get { return m_data.GetFloat("sim/joystick/fc_hdng");} }

        /// <summary>
        ///  Flight Control Pitch (sum of yoke plus artificial stability). Units:[-1..1]
        ///  Raw path: sim/joystick/FC_ptch
        /// </summary>
        public IXPDataRef<float> FC_ptch { get { return m_data.GetFloat("sim/joystick/fc_ptch");} }

        /// <summary>
        ///  Flight Control Roll (sum of yoke plus artificial stability). Units:[-1..1]
        ///  Raw path: sim/joystick/FC_roll
        /// </summary>
        public IXPDataRef<float> FC_roll { get { return m_data.GetFloat("sim/joystick/fc_roll");} }

        /// <summary>
        ///  The nullzone size for the pitch axis (as of 940, one null zone serves all 3 axes). Units:ratio
        ///  Raw path: sim/joystick/joystick_pitch_nullzone
        /// </summary>
        public IXPDataRef<float> joystick_pitch_nullzone { get { return m_data.GetFloat("sim/joystick/joystick_pitch_nullzone");} }

        /// <summary>
        ///  The nullzone size for the roll axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_roll_nullzone
        /// </summary>
        public IXPDataRef<float> joystick_roll_nullzone { get { return m_data.GetFloat("sim/joystick/joystick_roll_nullzone");} }

        /// <summary>
        ///  The nullzone size for the heading axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_heading_nullzone
        /// </summary>
        public IXPDataRef<float> joystick_heading_nullzone { get { return m_data.GetFloat("sim/joystick/joystick_heading_nullzone");} }

        /// <summary>
        ///  Joystick center for pitch axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_pitch_center
        /// </summary>
        public IXPDataRef<float> joystick_pitch_center { get { return m_data.GetFloat("sim/joystick/joystick_pitch_center");} }

        /// <summary>
        ///  Joystick center for roll axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_roll_center
        /// </summary>
        public IXPDataRef<float> joystick_roll_center { get { return m_data.GetFloat("sim/joystick/joystick_roll_center");} }

        /// <summary>
        ///  Joystick center for heading axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_heading_center
        /// </summary>
        public IXPDataRef<float> joystick_heading_center { get { return m_data.GetFloat("sim/joystick/joystick_heading_center");} }

        /// <summary>
        ///  Amount of artificial stability to add to the pitch.  This is AS set by user, not in Plane-Maker.. Units:ratio
        ///  Raw path: sim/joystick/joystick_pitch_augment
        /// </summary>
        public IXPDataRef<float> joystick_pitch_augment { get { return m_data.GetFloat("sim/joystick/joystick_pitch_augment");} }

        /// <summary>
        ///  Amount of artificial stability to add to the roll.  This is AS set by user, not in Plane-Maker.. Units:ratio
        ///  Raw path: sim/joystick/joystick_roll_augment
        /// </summary>
        public IXPDataRef<float> joystick_roll_augment { get { return m_data.GetFloat("sim/joystick/joystick_roll_augment");} }

        /// <summary>
        ///  Amount of artificial stability to add to the heading.  This is AS set by user, not in Plane-Maker.. Units:ratio
        ///  Raw path: sim/joystick/joystick_heading_augment
        /// </summary>
        public IXPDataRef<float> joystick_heading_augment { get { return m_data.GetFloat("sim/joystick/joystick_heading_augment");} }

        /// <summary>
        ///  The sensitivity for the pitch axis (the power ratio). Units:ratio
        ///  Raw path: sim/joystick/joystick_pitch_sensitivity
        /// </summary>
        public IXPDataRef<float> joystick_pitch_sensitivity { get { return m_data.GetFloat("sim/joystick/joystick_pitch_sensitivity");} }

        /// <summary>
        ///  The sensitivity for the roll axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_roll_sensitivity
        /// </summary>
        public IXPDataRef<float> joystick_roll_sensitivity { get { return m_data.GetFloat("sim/joystick/joystick_roll_sensitivity");} }

        /// <summary>
        ///  The sensitivity for the heading axis. Units:ratio
        ///  Raw path: sim/joystick/joystick_heading_sensitivity
        /// </summary>
        public IXPDataRef<float> joystick_heading_sensitivity { get { return m_data.GetFloat("sim/joystick/joystick_heading_sensitivity");} }

        /// <summary>
        ///  Assignments for the joystick axes - what does X-Plane think each one is? [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:enums
        ///  Raw path: sim/joystick/joystick_axis_assignments
        /// </summary>
        public IXPDataRef<int[]> joystick_axis_assignments { get { return m_data.GetIntArray("sim/joystick/joystick_axis_assignments");} }

        /// <summary>
        ///  Assignments for the joystick buttons - what does each one do? [Was 64 before 850][was 160 before 900]. Units:enums
        ///  Raw path: sim/joystick/joystick_button_assignments
        /// </summary>
        public IXPDataRef<int[]> joystick_button_assignments { get { return m_data.GetIntArray("sim/joystick/joystick_button_assignments");} }

        /// <summary>
        ///  Reverse this axis? [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:boolean
        ///  Raw path: sim/joystick/joystick_axis_reverse
        /// </summary>
        public IXPDataRef<bool[]> joystick_axis_reverse { get { return m_data.GetBoolArray("sim/joystick/joystick_axis_reverse");} }

        /// <summary>
        ///  The deflection of this joystick [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        ///  Raw path: sim/joystick/joystick_axis_values
        /// </summary>
        public IXPDataRef<float[]> joystick_axis_values { get { return m_data.GetFloatArray("sim/joystick/joystick_axis_values");} }

        /// <summary>
        ///  Min raw value ever seen [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        ///  Raw path: sim/joystick/joystick_axis_minimum
        /// </summary>
        public IXPDataRef<float[]> joystick_axis_minimum { get { return m_data.GetFloatArray("sim/joystick/joystick_axis_minimum");} }

        /// <summary>
        ///  Max raw value ever seen [Was 15 before 850][Was 24 before 860][was 32 before 900]. Units:ratio
        ///  Raw path: sim/joystick/joystick_axis_maximum
        /// </summary>
        public IXPDataRef<float[]> joystick_axis_maximum { get { return m_data.GetFloatArray("sim/joystick/joystick_axis_maximum");} }

        /// <summary>
        ///  Is this button pressed? [Was 64 before 850][was 160 before 900]. Units:boolean
        ///  Raw path: sim/joystick/joystick_button_values
        /// </summary>
        public IXPDataRef<bool[]> joystick_button_values { get { return m_data.GetBoolArray("sim/joystick/joystick_button_values");} }

        /// <summary>
        ///  True if there is joystick hardware of some kind providing this axis right now.. Units:boolean
        ///  Raw path: sim/joystick/joy_mapped_axis_avail
        /// </summary>
        public IXPDataRef<bool[]> joy_mapped_axis_avail { get { return m_data.GetBoolArray("sim/joystick/joy_mapped_axis_avail");} }

        /// <summary>
        ///  Fully processed ratio for each axis - either -1 to 1 or 0 to 1.. Units:float
        ///  Raw path: sim/joystick/joy_mapped_axis_value
        /// </summary>
        public IXPDataRef<float[]> joy_mapped_axis_value { get { return m_data.GetFloatArray("sim/joystick/joy_mapped_axis_value");} }

        /// <summary>
        ///  Hardware settings: Pedal nobrk (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_ped_nobrk
        /// </summary>
        public IXPDataRef<bool> eq_ped_nobrk { get { return m_data.GetBool("sim/joystick/eq_ped_nobrk");} }

        /// <summary>
        ///  Hardware settings: Pedal wlbrk (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_ped_wibrk
        /// </summary>
        public IXPDataRef<bool> eq_ped_wibrk { get { return m_data.GetBool("sim/joystick/eq_ped_wibrk");} }

        /// <summary>
        ///  Equipment settings: PFC pedal (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_pedals
        /// </summary>
        public IXPDataRef<bool> eq_pfc_pedals { get { return m_data.GetBool("sim/joystick/eq_pfc_pedals");} }

        /// <summary>
        ///  Equipment settings: PFC yoke (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_yoke
        /// </summary>
        public IXPDataRef<bool> eq_pfc_yoke { get { return m_data.GetBool("sim/joystick/eq_pfc_yoke");} }

        /// <summary>
        ///  Equipment settings: PFC throttle (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_throt
        /// </summary>
        public IXPDataRef<bool> eq_pfc_throt { get { return m_data.GetBool("sim/joystick/eq_pfc_throt");} }

        /// <summary>
        ///  Equipment settings: PFC avionics (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_avio
        /// </summary>
        public IXPDataRef<bool> eq_pfc_avio { get { return m_data.GetBool("sim/joystick/eq_pfc_avio");} }

        /// <summary>
        ///  Equipment settings: PFC center console (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_centercon
        /// </summary>
        public IXPDataRef<bool> eq_pfc_centercon { get { return m_data.GetBool("sim/joystick/eq_pfc_centercon");} }

        /// <summary>
        ///  Equipment settings: PFC electric trim (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_elec_trim
        /// </summary>
        public IXPDataRef<bool> eq_pfc_elec_trim { get { return m_data.GetBool("sim/joystick/eq_pfc_elec_trim");} }

        /// <summary>
        ///  Equipment settings: PFC brake toggle (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_brake_tog
        /// </summary>
        public IXPDataRef<bool> eq_pfc_brake_tog { get { return m_data.GetBool("sim/joystick/eq_pfc_brake_tog");} }

        /// <summary>
        ///  Equipment settings: PFC dual cowl (writable since 930 to auto-set user preferences). Units:boolean
        ///  Raw path: sim/joystick/eq_pfc_dual_cowl
        /// </summary>
        public IXPDataRef<bool> eq_pfc_dual_cowl { get { return m_data.GetBool("sim/joystick/eq_pfc_dual_cowl");} }

        /// <summary>
        ///  True if the fire key is held down. Units:boolean
        ///  Raw path: sim/joystick/fire_key_is_down
        /// </summary>
        public IXPDataRef<bool> fire_key_is_down { get { return m_data.GetBool("sim/joystick/fire_key_is_down");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the roll.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_roll
        /// </summary>
        public IXPDataRef<bool> has_certified_roll { get { return m_data.GetBool("sim/joystick/has_certified_roll");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the pitch.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_pitch
        /// </summary>
        public IXPDataRef<bool> has_certified_pitch { get { return m_data.GetBool("sim/joystick/has_certified_pitch");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the heading.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_heading
        /// </summary>
        public IXPDataRef<bool> has_certified_heading { get { return m_data.GetBool("sim/joystick/has_certified_heading");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the brakes.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_brakes
        /// </summary>
        public IXPDataRef<bool> has_certified_brakes { get { return m_data.GetBool("sim/joystick/has_certified_brakes");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the throttle.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_throttle
        /// </summary>
        public IXPDataRef<bool> has_certified_throttle { get { return m_data.GetBool("sim/joystick/has_certified_throttle");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the pitch.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_prop
        /// </summary>
        public IXPDataRef<bool> has_certified_prop { get { return m_data.GetBool("sim/joystick/has_certified_prop");} }

        /// <summary>
        ///  True if there is FAA-certified hardware controlling the mixture.. Units:boolean
        ///  Raw path: sim/joystick/has_certified_mixture
        /// </summary>
        public IXPDataRef<bool> has_certified_mixture { get { return m_data.GetBool("sim/joystick/has_certified_mixture");} }
    }
}