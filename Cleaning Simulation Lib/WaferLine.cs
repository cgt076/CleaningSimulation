using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Simulation_Lib
{
    public class WaferLine
    {
        public WaferLine(int no)
        {
            No = no;
        }

        public int No // 장비 라인 번호
        { 
            get;
        }

        public int Spin // 회전속도
        {
            get;
            set;
        }

        public int Drop // 낙하속도
        {
            get;
            set;
        }

        public int Diw // DI Water 개수
        {
            get;
            set;
        }

        public int Time // 진행 시간
        {
            get;
            set;
        }

        public int Hf //불화 수소 용액량
        {
            get;
            set;
        }

        public int Sc1
        {
            get;
            set;
        }

        public int Sc2
        {
            get;
            set;
        }


        public override string ToString()
        {
            return string.Format("{0}번 라인",No);
        }
    }
}
