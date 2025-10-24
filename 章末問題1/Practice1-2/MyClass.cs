namespace Practice1_2 {
    /// <summary>
    /// MyClass型の2数を保持するクラス
    /// </summary>
    class MyClass {
        /// <summary>
        /// 1つ目の数値
        /// </summary>
        public int X;
        /// <summary>
        /// 2つ目の数値
        /// </summary>
        public int Y;
        /// <summary>
        /// MyClass型の2数を初期化するコンストラクタ
        /// </summary>
        /// <param name="vX">1つ目に設定する数値</param>
        /// <param name="vY">2つ目に設定する数値</param>
        public MyClass(int vX, int vY) {
            this.X = vX;
            this.Y = vY;
        }
    }
}
