using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// 四則演算子enum宣言
    /// </summary>
    public enum _CalOperator
    {
        _none,
        _plus,
        _minus,
        _multiple,
        _divide
    }


    /// <summary>
    /// 計算機で計算を行う親クラス
    /// </summary>
    public abstract class CalNumberClass
    {

        #region グローバル変数宣言または初期化
        /// <summary>
        /// 現在計算された値を保存する結果値。
        /// </summary>
        public static decimal calResult { get; set; } = 0;

        /// <summary>
        /// イコール（＝）ボタンを２回以上押下する場合 - 最後入力数字、計算Historyで右にある。
        /// </summary>
        public static decimal fixedBaseNumber { get; set; } = 0;

        /// <summary>
        /// 現在入力された四則演算のオペレーター。
        /// </summary>
        public static _CalOperator currentCalOperator { get; set; } = _CalOperator._none;

        /// <summary>
        /// 直前に入力したり、行った四則演算子オペレーター。
        /// </summary>
        public static _CalOperator lastCalOperator { get; set; } = _CalOperator._none;

        /// <summary>
        /// グローバル変数初期化関数。
        /// </summary>
        public static void ClearCalculation()
        {
            calResult = 0;
            fixedBaseNumber = 0;
            currentCalOperator = _CalOperator._none;
            lastCalOperator = _CalOperator._none;
        }
        #endregion

        /// <summary>
        /// 計算機で現在計算を行う演算子オペレーターを設定するメソッド。
        /// </summary>
        /// <param name="calOperator">計算機で押下する演算子</param>
        public static void SetOperator(_CalOperator calOperator)
        {
            // 直前の演算子を現在の演算子値に設定。
            lastCalOperator = currentCalOperator;

            // 現在演算子をパラメータに伝える演算子に設定。
            currentCalOperator = calOperator;
        }

        #region Abstract Class Method

        /// <summary>
        /// 演算子だけ入力する場合計算する関数
        /// </summary>
        /// <returns></returns>
        public abstract bool Calculation();

        /// <summary>
        /// 数字入力後演算子を入力する場合計算する巻子
        /// </summary>
        /// <param name="leftNumberA"></param>
        /// <returns></returns>
        public abstract bool Calculation(decimal leftNumberA);

        /// <summary>
        /// 「数字 → 演算子 → 数字」順で入力後イコール「＝」ボタンを押下する場合計算する関数
        /// </summary>
        /// <param name="leftNumberA"></param>
        /// <param name="leftNumberB"></param>
        /// <returns></returns>
        public abstract bool Calculation(decimal leftNumberA, decimal rightNumberB);

        #endregion
    }

    #region １。Plus機能実装

    /// <summary>
    /// Plus機能クラス
    /// </summary>
    public class Plus : CalNumberClass
    {
        public override bool Calculation()
        {
            try
            {   
                // 何もしない。
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA)
        {
            try
            {
                calResult += leftNumberA;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA, decimal rightNumberB)
        {
            try
            {   
                calResult = leftNumberA + rightNumberB;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    #endregion

    #region ２。Minus機能実装

    /// <summary>
    /// Minus機能クラス
    /// </summary>
    public class Minus : CalNumberClass
    {
        public override bool Calculation()
        {
            try
            {
                // 何もしない。
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA)
        {
            try
            {
                calResult -= leftNumberA;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA, decimal rightNumberB)
        {
            try
            {
                calResult = leftNumberA - rightNumberB;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    #endregion

    #region ３。掛け算機能実装

    /// <summary>
    /// 掛け算機能クラス
    /// </summary>
    public class Multiple : CalNumberClass
    {
        public override bool Calculation()
        {
            try
            {
                // 何もしない。
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA)
        {
            try
            {
                calResult *= leftNumberA;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA, decimal rightNumberB)
        {
            try
            {
                calResult = leftNumberA * rightNumberB;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    #endregion

    #region ４。割り算機能実装

    /// <summary>
    /// 割り算機能クラス
    /// </summary>
    public class Divide : CalNumberClass
    {
        public override bool Calculation()
        {
            try
            {
                // 何もしない。
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA)
        {
            try
            {
                calResult /= leftNumberA;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public override bool Calculation(decimal leftNumberA, decimal rightNumberB)
        {
            try
            {
                calResult = leftNumberA / rightNumberB;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    #endregion
}
