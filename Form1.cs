using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class frmMain : Form
    {

        /// <summary>
        /// キーの入力を処理するクラス
        /// 数字キー 0~9、小数点、四則演算、等全てのキーを初期化
        /// </summary>
        CalKeyPressProcess calKeyPressProcess = new CalKeyPressProcess();

        /// <summary>
        ///  Main Form 生成
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            calKeyPressProcess.ResetCalculation(DisplayCallback);

            CalNumberClass.calResult = 105;
        }

        #region １。 数字キー 0~9、 小数点、 バックスペース Event処理 

        /// <summary>
        /// 0~9の数字キーを処理する関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void NumberKeyPress_0to9_Event(object sender, EventArgs e)
        {
            string strNumber = "";
            strNumber = (sender as Button).Text;

            calKeyPressProcess.AddNumber(strNumber, DisplayCallback);
        }

        /// <summary>
        /// 小数点が入力される時処理する関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDot_Click(object sender, EventArgs e)
        {
            calKeyPressProcess.AddDot(DisplayCallback);
        }

        /// <summary>
        /// バックスペースキーを押下する時処理する関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            calKeyPressProcess.BackSpaceProcess(DisplayCallback);
        }

        #endregion


        #region 2. 四則演算関連

        /// <summary>
        /// 四則演算のきーを押下する時処理するEvent関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Btn4KindOperatorPress_Event(object sender, EventArgs e)
        {
            string strOperator = "";
            strOperator = (sender as Button).Text;

            calKeyPressProcess.CalOperatorProcess(strOperator, DisplayCallback);
        }


        #endregion


        #region 3. イコール（＝）キーのEvent処理

        /// <summary>
        /// イコール（＝）キーを押下する時処理するEvent関数 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            calKeyPressProcess.EqualKeyProcess(DisplayCallback);
        }

        #endregion


        #region 4. C - 計算の初期化, CE - 直前に入力したキー初期化、Event処理

        /// <summary>
        /// Clearキーを押下する時処理する関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            calKeyPressProcess.ResetCalculation(DisplayCallback);
        }

        /// <summary>
        /// 最後に入力された値を初期化するキーのEvnet関数
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLast_Click(object sender, EventArgs e)
        {
            calKeyPressProcess.ClearLastInput(DisplayCallback);
        }

        #endregion

        /// <summary>
        /// キーを入力した後画面の情報を表すCallback関数
        /// </summary>
        /// <param name="calHistory">計算中の直前段階のHistory情報</param>
        /// <param name="calDisplayInfo">現在入力中の値、あるいは計算結果値表示</param>
        void DisplayCallback(string calHistory, string calDisplayInfo)
        {
            lblCalHistory.Text = calHistory;
            lblInputNumberOrResult.Text = calDisplayInfo;
        }
    }
}