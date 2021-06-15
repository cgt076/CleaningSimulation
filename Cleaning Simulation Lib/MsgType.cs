namespace Cleaning_Simulation_Lib
{
    public enum MsgType
    {
        /// <summary>
        /// 서버 정보 메시지(모니터->공장)
        /// </summary>
        MSG_MF_ADDSI,
        /// <summary>
        /// 웨이퍼(모니터->공장)
        /// </summary>
        MSG_MF_ADDWF,
        /// <summary>
        /// HF
        /// </summary>
        MSG_MF_ADDHF,
        /// <summary>
        /// SC1
        /// </summary>
        MSG_MF_ADDSC1,
        /// <summary>
        /// SC2
        /// </summary>
        MSG_MF_ADDSC2,
        /// <summary>
        /// 스핀속도
        /// </summary>
        MSG_MF_SETSP,
        /// <summary>
        /// 케미컬 낙하속도
        /// </summary>
        MSG_MF_SETDP,


        MSG_FM_ADDLN,
        MSG_FM_ADDWF,
        MSG_FM_ADDHF,
        MSG_FM_ADDSC1,
        MSG_FM_ADDSC2,
        MSG_FM_SETSP,
        MSG_FM_SETDR
    }
}