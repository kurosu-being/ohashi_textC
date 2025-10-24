namespace Practice1_2 {
    /// <summary>
    /// MyStruct型の2数を保持する構造体
    /// </summary>
    struct MyStruct {
        /// <summary>
        /// 1つ目の数値
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 2つ目の数値
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// MyStruct型の2数を初期化するコンストラクタ
        /// </summary>
        /// <param name="vX">1つ目に設定する数値</param>
        /// <param name="vY">2つ目に設定する数値</param>
        public MyStruct(int vX, int vY) {
            this.X = vX;
            this.Y = vY;
        }
    }
}
