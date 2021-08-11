using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PLC_Controller
{
    public partial class Form1 : Form
    {


        PLCAction PLCAction = new PLCAction();
        int ManualMode; //手動切換模式 2:步階
        double XCurPos, YCurPos, ZCurPos;
        System.Threading.Timer timer2;
        Thread ManualMarkThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PLCAction.PLC_Connect(0);
            //20180920 蕭兄建議開啟後通通初始化
            PLCAction.PLC_AllInitial();

            TimerCallback callback = new TimerCallback(_do);
            timer2 = new System.Threading.Timer(callback, null, 0, 500);//500豪秒起來一次

            ManualAsnPosMoveBtn.Enabled = false;

        }
        private void ManualSet()
        {
            double _StepDistVal = Convert.ToDouble(ManualStepDistComboBox.Text);
            double _XSpeedVal = 3000;//Convert.ToDouble(ManualXSpeedTxtBox.Text);
            double _YSpeedVal = 3000;//Convert.ToDouble(ManualYSpeedTxtBox.Text);
            double _ZSpeedVal = 3000;//Convert.ToDouble(ManualZSpeedTxtBox.Text);
            double _SpeedRateVal = 100;//Convert.ToDouble(ManualSpeedRateLbl.Text);

            PLCAction.ManualSet(_StepDistVal, _XSpeedVal, _YSpeedVal, _ZSpeedVal, _SpeedRateVal);// for 吋動需要修改步階距離

        }
        private void _do(object state)
        {

            this.BeginInvoke(new setlabel2(setlabel3));//委派

        }
        delegate void setlabel2();
        private void setlabel3()
        {

            //每秒更新一次
            //CurTimeLbl.Text = DateTime.Now.ToString("HH:mm:ss");


            // ReadPLCDataRandom 一次呼叫完畢,節省時間
            double[] _ReadVal = PLCAction.ReadPLCDataRandom("D1000\nD1001\nD1010\nD1011\nR1000\nR1001\nR1010\nR1011\nD1006\nD1007" //1-2-3-4-5
                                                         + "\nD1016\nD1017\nR1002\nR1003\nR1012\nR1013\nM1107\nM1117\nM1102\nM1105" //6-7-8--9-10-11-12
                                                         + "\nM1112\nM1115\nM1209\nM1600\nM1601\nM1602\nM1603\nM1604\nM1605\nM1606" //13-14-15-16-17-18-19-20-21-22
                                                         + "\nM1607\nM1608\nM1609\nM1610\nM1611\nM1602\nM1002\nM1012\nD1020\nD1021"// 23-24-25-26-27-28-29-30--31
                                                         + "\nR1020\nR1021\nD1026\nD1027\nR1022\nR1023\nM1122\nM1125"//32-33-34--35-36
                                                         + "\nM1613\nM1614\nM1615", 51);//37-38-39

            //// hardcode 上面順序比較節省尋找時間
            XCurPos = Math.Round(_ReadVal[0], 3); //D1000
            YCurPos = Math.Round(_ReadVal[1], 3); //D1010
            ZCurPos = Math.Round(_ReadVal[30], 3); //D1020

            XCurPosTxtBox.Text = XCurPos.ToString();
            YCurPosTxtBox.Text = YCurPos.ToString();
            ZCurPosTxtBox.Text = ZCurPos.ToString();

            //AutoXTgtTxtBox.Text = Math.Round(_ReadVal[2], 3).ToString();  //R1000
            //AutoYTgtTxtBox.Text = Math.Round(_ReadVal[3], 3).ToString();  //R1010
            //AutoZTgtTxtBox.Text = Math.Round(_ReadVal[31], 3).ToString();  //R1020


            //AutoXSpeedTxtBox.Text = (Math.Round(_ReadVal[4], 3) * 100).ToString(); //D1006
            //AutoYSpeedTxtBox.Text = (Math.Round(_ReadVal[5], 3) * 100).ToString(); //D1016
            //AutoZSpeedTxtBox.Text = (Math.Round(_ReadVal[32], 3) * 100).ToString(); //D1026


            //SetXSpeedTxtBox.Text = (Math.Round(_ReadVal[6], 3) * 100).ToString(); //R1002
            //SetYSpeedTxtBox.Text = (Math.Round(_ReadVal[7], 3) * 100).ToString(); //R1012
            //SetZSpeedTxtBox.Text = (Math.Round(_ReadVal[33], 3) * 100).ToString(); //R1022


            //XGoHomeStatus = Convert.ToInt32(_ReadVal[8]); //M1107
            //YGoHomeStatus = Convert.ToInt32(_ReadVal[9]); //M1117

            //XCatchStatus = Convert.ToInt32(_ReadVal[10]); //M1102
            //XMoveStatus = Convert.ToInt32(_ReadVal[11]);  //M1105
            //YCatchStatus = Convert.ToInt32(_ReadVal[12]); //M1112
            //YMoveStatus = Convert.ToInt32(_ReadVal[13]);  //M1115
            //ZCatchStatus = Convert.ToInt32(_ReadVal[34]); //M1122
            //ZMoveStatus = Convert.ToInt32(_ReadVal[35]);  //M1125


            //if (XMoveStatus == 1) XMoveStatusTxtBox.Text = "移動中";
            //else XMoveStatusTxtBox.Text = "靜止";
            //if (YMoveStatus == 1) YMoveStatusTxtBox.Text = "移動中";
            //else YMoveStatusTxtBox.Text = "靜止";
            //if (ZMoveStatus == 1) ZMoveStatusTxtBox.Text = "移動中";
            //else ZMoveStatusTxtBox.Text = "靜止";

            //系統交握訊號讀回

            // M1209 = Convert.ToInt32(_ReadVal[14]); //M1209
            //讀回系統M1209交握值
            //M1209 = PLCAction.PLC_HandShakingRead();

            ////判斷自動流程狀態
            ////0完全停止(下次會從頭開始)1暫停(下次從指定位置開始)2啟動
            //if (AutoModeStatus == 0)
            //{
            //    AutoModeStatusLbl.Text = "停止";
            //    AutoModeStatusLbl2.Text = "停止";
            //}
            //else if (AutoModeStatus == 1)
            //{
            //    AutoModeStatusLbl.Text = "暫停";
            //    AutoModeStatusLbl2.Text = "暫停";
            //}
            //else if (AutoModeStatus == 2)
            //{
            //    AutoModeStatusLbl.Text = "自動模式執行中";
            //    AutoModeStatusLbl2.Text = "自動模式執行中";
            //}

            //XSpeedLbl.Text = Convert.ToString(AutoReXArea);
            //YSpeedLbl.Text = Convert.ToString(AutoReYArea);

            //AlmMsgTxtBox.Clear();
            //if (_ReadVal[15] == 1)
            //    AlmMsgTxtBox.Text += "X軸下極限(M1600),";
            //if (_ReadVal[16] == 1)
            //    AlmMsgTxtBox.Text += "X軸上極限(M1601),";
            //if (_ReadVal[17] == 1)
            //    AlmMsgTxtBox.Text += "Y軸下極限(M1602),";
            //if (_ReadVal[18] == 1)
            //    AlmMsgTxtBox.Text += "Y軸上極限(M1603),";
            //if (_ReadVal[19] == 1)
            //    AlmMsgTxtBox.Text += "Z軸下極限(M1604),";
            //if (_ReadVal[20] == 1)
            //    AlmMsgTxtBox.Text += "Z軸上極限(M1605),";
            //if (_ReadVal[21] == 1)
            //    AlmMsgTxtBox.Text += "平台馬達異常(M1606),";
            //if (_ReadVal[22] == 1)
            //    AlmMsgTxtBox.Text += "監控系統急停(M1607),";
            //if (_ReadVal[23] == 1)
            //    AlmMsgTxtBox.Text += "雷射源急停(M1608),";
            //if (_ReadVal[24] == 1)
            //    AlmMsgTxtBox.Text += "X軸需復歸(M1610),";
            //if (_ReadVal[25] == 1)
            //    AlmMsgTxtBox.Text += "Y軸需復歸(M1611),";
            //if ((ThreadAlive == 0 || ThreadAlive == -1) && XCatchStatus == 1)
            //    AlmMsgTxtBox.Text += "X軸一速移動卡住(M1002),";
            //if ((ThreadAlive == 0 || ThreadAlive == -1) && YCatchStatus == 1)
            //    AlmMsgTxtBox.Text += "Y軸一速移動卡住(M1012),";
            //if (_ReadVal[26] == 1)
            //    AlmMsgTxtBox.Text += "Z軸需復歸(M1612),";
            //if (_ReadVal[36] == 1)
            //    AlmMsgTxtBox.Text += "X軸ERROR,";
            //if (_ReadVal[37] == 1)
            //    AlmMsgTxtBox.Text += "Y軸ERROR,";
            //if (_ReadVal[38] == 1)
            //    AlmMsgTxtBox.Text += "Z軸ERROR,";
            //if (GoHomePause == 1)
            //    AlmMsgTxtBox.Text += "歸Home動作已暫停,必須繼續完成歸Home動作才能繼續其他動作";

            ////收集所有 alm 訊息
            //ProdAlmMsg = ProdAlmMsg + AlmMsgTxtBox.Text;
        }
        private void ManualZNegBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("ZNeg");

            }
        }

        private void ManualXNegBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("XNag");
            }
        }

        private void ManualStepRadioBox_Click(object sender, EventArgs e)
        {
            ManualMode = 2;
            ManualSet();
            PLCAction.axActUtlType1.SetDevice("M1201", 1);//步階
            ManualAsnPosRadioBtn.Checked = false;
            ManualAsnPosMoveBtn.Enabled = false;

        }

        private void ManualNoStopRadioBtn_Click(object sender, EventArgs e)
        {
            ManualMode = 1;
            ManualSet();
            PLCAction.axActUtlType1.SetDevice("M1201", 0);//連續移動
            ManualAsnPosRadioBtn.Checked = false;
            ManualAsnPosMoveBtn.Enabled = false;
        }

        private void ManualXPosBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("XPos");
            }
        }

        private void ManualZPosBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("ZPos");
            }
        }

        private void ManualYPosBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("YPos");

            }
        }

        private void ManualYNegBtn_Click(object sender, EventArgs e)
        {
            if (ManualMode == 2)
            {
                ManualSet();
                PLCAction.ManualStep("YNag");

            }
        }

        private void ManualZNegBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("ZNeg");

            }
        }

        private void ManualZNegBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();
            }
        }

        private void ManualXNegBtn_MouseDown(object sender, MouseEventArgs e)
        {

            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("XNag");
            }
        }

        private void ManualXNegBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();

            }
        }

        private void ManualXPosBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("XPos");

            }
        }

        private void ManualXPosBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();
            }
        }

        private void ManualZPosBtn_MouseDown(object sender, MouseEventArgs e)
        {
            //要記得先連通PLC才能執行
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("ZPos");

            }
        }

        private void ManualZPosBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();
            }
        }

        private void ManualYPosBtn_MouseDown(object sender, MouseEventArgs e)
        {
            //要記得先連通PLC才能執行
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("YPos");


            }
        }

        private void ManualYPosBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();
            }
        }

        private void ManualYNegBtn_MouseDown(object sender, MouseEventArgs e)
        {
            //要記得先連通PLC才能執行
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinous("YNag");

            }
        }

        private void ManualYNegBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (ManualMode == 1)
            {
                ManualSet();
                PLCAction.ManualContinousPause();

            }
        }

        private void ManualAsnPosMoveBtn_Click(object sender, EventArgs e)
        {
            ManualMarkThread = new Thread(new ThreadStart(ManualMark));
            Form.CheckForIllegalCrossThreadCalls = false; // 存取 UI 時需要用,較不安全的寫法,改用委派較佳(EX: UPDATE TXTBOX)
            ManualMarkThread.Start();
        }
        private void ManualMark()
        {

            //平台走位
            double ManualXPos = Convert.ToDouble(ManualXPosTxtBox.Text);
            double ManualYPos = Convert.ToDouble(ManualYPosTxtBox.Text);
            double ManualZPos = Convert.ToDouble(ManualZPosTxtBox.Text);
            PLCAction.AutoStageMove(ManualXPos, ManualYPos, ManualZPos, 100);//預設手動走3000,100%
            MessageBox.Show(this, "已移動至指定位置!");

        }

        private void ManualAsnPosRadioBtn_Click(object sender, EventArgs e)
        {
            ManualStepRadioBox.Checked = false;
            ManualNoStopRadioBtn.Checked = false;
            ManualAsnPosMoveBtn.Enabled = true;
        }

    }
}
