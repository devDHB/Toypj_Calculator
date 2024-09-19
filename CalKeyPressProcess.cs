using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    /// <summary>
    /// Calculator キーの入力処理クラス。
    /// </summary>
    public class CalKeyPressProcess
    {
        /// <summary>
        /// 直前の計算式のHistoryを表示する文字テキスト。
        /// </summary>
        string strCalHistory { get; set; } = "";

        /// <summary>
        /// 現在計算された結果値を表示する文字テキスト。
        /// </summary>
        string strCalResult { get; set; } = "";

        /// <summary>
        /// 現在入力された数字、小数点を表示する文字テキスト。
        /// </summary>
        string strInputNumber { get; set; } = "";

        #region 1. C、CEボタンを処理するメソッド

        /// <summary>
        /// 計算機の全体初期化
        /// １。Formが初めて実行される時呼び出し。
        /// ２。Cボタンを押下する時呼び出し。
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void ResetCalculation(Action<string, string> dispCallBack)
        {
            strCalHistory = "";
            strCalResult = "";
            strInputNumber = "0";

            dispCallBack(strCalHistory, strInputNumber);
        }

        /// <summary>
        /// 1. CEキーを押下する時呼び出し。
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void ClearLastInput(Action<string, string> dispCallBack)
        {

            // 直前に入力した値を初期化。
            strInputNumber = "0";

            // 画面の情報をCallback関数で更新。
            dispCallBack(strCalHistory, strInputNumber);
        }
        #endregion

        #region 2. 数字キー0~9、小数点、バックスペースキーの入力を処理するメソッド

        /// <summary>
        /// 数字0~9を入力すると呼び出すメソッド。숫자 0~9가 입력되면 호출되는 메소드
        /// </summary>
        /// <param name="strNum"></param>
        /// <param name="dispCallBack"></param>
        public void AddNumber(string strNum, Action<string, string> dispCallBack)
        {
            // 全部初期化後、最初入力時は「strInputText」に今入力した値が入力される。
            if (strInputNumber == "0") { 
                strInputNumber = strNum;
            } else
            {
                strInputNumber += strNum;
            }

            dispCallBack(strCalHistory, strInputNumber);
        }

        public void AddDot(Action<string, string> dispCallBack)
        {
        　　// 小数点があれば動作しなくて終了。
            if (strInputNumber.Contains("."))
            {
                return;
            }
            else
            {
                // 現在値が0なら「0 + .」を表記。
                if(strInputNumber == "0")
                {
                    strInputNumber = "0.";
                }
                else
                {
                    // 現在値に小数点を追加。
                    strInputNumber += ".";
                }
            }
            dispCallBack(strCalHistory, strInputNumber);
        }

        /// <summary>
        /// バックスペースキーを押下する時呼び出すメソッド。
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void BackSpaceProcess(Action<string, string> dispCallBack)
        {
            if (strInputNumber =="0" || strInputNumber == "" || strInputNumber.Length == 1)
            {
                strInputNumber = "0";
            }
            else
            {
                strInputNumber = strInputNumber.Substring(0, strInputNumber.Length -1 );
            }

            // 画面の情報をCallback関数で更新。
            dispCallBack(strCalHistory, strInputNumber);
        }

        #endregion

        #region 3. 四則演算のキーの入力を処理するメソッド。

        /// <summary>
        /// 四則演算のキーを押下する時呼び出すメソッド。
        /// + - * /
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void CalOperatorProcess(string strCalOperator, Action<string, string> dispCallBack)
        {
            // 画面の情報をCallback関数で更新。
            dispCallBack(strCalHistory, strInputNumber);
        }

        #endregion

        #region 4. イコール（＝）演算子を処理するメソッド。이퀄 = 연산자를 처리하는 메소드

        /// <summary>
        /// イコール（＝）キーを押下する時呼び出すメソッド。
        /// 이퀄 = 연산자 입력될 경우 호출되는 메소드
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void EqualKeyProcess(Action<string, string> dispCallBack)
        {
            // 画面の情報をCallback関数で更新。　화면 정보를 Callback 함수로 갱신
            dispCallBack(strCalHistory, strInputNumber);
        }

        #endregion
    }
}