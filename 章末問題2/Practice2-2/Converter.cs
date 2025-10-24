namespace Practice2_2 {
    /// <summary>
    /// インチをメートルに変換するクラス
    /// </summary>
    internal class Converter {
        /// <summary>
        /// 1インチあたりのメートル換算比率
        /// </summary>
        private const double C_Ratio = 0.0254;
        /// <summary>
        /// インチを取得してメートルに変換する
        /// </summary>
        /// <param name="vInch">入力されたインチ</param>
        /// <returns></returns>
        public static double ConverterInchToMeter(double vInch) {
            return vInch * C_Ratio;
        }
    }
}