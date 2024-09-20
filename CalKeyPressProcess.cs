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

            CalNumberClass.ClearCalculation();

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
            if (strInputNumber == "0" || is4KindOperatorTriggeredOn == true) 
            { 
                // 現在入力された数字を入力文字に設定する。
                strInputNumber = strNum;

                if (is4KindOperatorTriggeredOn == true)
                {
                    // 四則演算子のflagがtrueならfalseに初期化する。
                    is4KindOperatorTriggeredOn = false;
                }
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
        /// 현재 입력된 연산자 Tag를 체크하여 계산에 사용될 오퍼레이터를 얻는다
        /// </summary>
        /// <param name="strOperator"></param>
        /// <returns></returns>
        _CalOperator GetOperator(string strOperator)
        {
            _CalOperator result = _CalOperator._none;

            switch(strOperator)
            {
                case "_plus":
                    result = _CalOperator._plus;
                    break;
                case "_minus":
                    result = _CalOperator._minus;
                    break;
                case "_multiple":
                    result = _CalOperator._multiple;
                    break;
                case "_divide":
                    result = _CalOperator._divide;
                    break;
            }
            return result;
        }

        /// <summary>
        /// 現在設定された演算子を画面に表示するため記号を得る
        /// </summary>
        /// <param name="calOperator"></param>
        /// <returns></returns>
        string GetOperatorString(_CalOperator calOperator)
        {
            string result = "";
            switch (calOperator)
            {
                case _CalOperator._plus:
                    result = "+";
                    break;
                case _CalOperator._minus:
                    result = "-";
                    break;
                case _CalOperator._multiple:
                    result = "*";
                    break;
                case _CalOperator._divide:
                    result = "/ ";
                    break;
            }
            return ""; // return = string.Empty;
        }

        /// <summary>
        /// 四則演算のキーを押下する時呼び出すメソッド。
        /// + - * /
        /// </summary>
        /// <param name="dispCallBack"></param>
        public void CalOperatorProcess(string strCalOperator, Action<string, string> dispCallBack)
        {

            

            // 現在入力された演算子を計算機クラスに設定する。
            CalNumberClass.SetOperator(GetOperator(strCalOperator));
            
            if (is4KindOperatorTriggeredOn != true)
            {
                is4KindOperatorTriggeredOn = true;
            }
            
            // 演算子計算処理をする。
            CalculationProcess();

            // 直前s入力した計算の情報をテキストで生成。
            strCalHistory = string.Format("{0} {1}", CalNumberClass.calResult, GetOperatorString(CalNumberClass.currentCalOperator));

            // 直前入力した値または計算結果をテキストで生成。
            strInputNumber = CalNumberClass.calResult.ToString();


            // 画面の情報をCallback関数で更新。
            dispCallBack(strCalHistory, strInputNumber);
        }


        /// <summary>
        /// 四則演算子ボタンを押したかチェック
        /// 1. 設定:四則演算子入力時True
        /// 2. 解体:数字0~9、小数点·イコール·クリアが入力されたら解除False
        /// </summary>
        bool is4KindOperatorTriggeredOn { get; set; } = false;


        bool CalculationProcess()
        {
            CalNumberClass clnc = GetCalculationMethod(CalNumberClass.currentCalOperator);

            decimal inputNumber = 0;
            if (decimal.TryParse(strInputNumber,out inputNumber)) {
                clnc.Calculation(inputNumber);
                return true;
            }

            return false;
        }

        /// <summary>
        /// 伝達された四則演算子の種類によって計算を進める
        /// 子クラスインスタンスを生成して得る。
        /// </summary>
        /// <param name="calOperator"></param>
        /// <returns></returns>
        CalNumberClass GetCalculationMethod(_CalOperator calOperator)
        {
            CalNumberClass clnc = null;
            switch (calOperator)
            {
                case _CalOperator._plus:
                    clnc = new Plus();
                    break;
                case _CalOperator._minus:
                    clnc = new Minus();
                    break;
                case _CalOperator._multiple:
                    clnc = new Multiple();
                    break;
                case _CalOperator._divide:
                    clnc = new Divide();
                    break;
            }
            return clnc;
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