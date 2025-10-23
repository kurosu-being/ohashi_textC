
namespace Practice1_2 {
    /// <summary>
    /// MyStruct型の2数を保持する構造体
    /// </summary>
    struct MyStruct {
        /// <summary>
        /// 一つ目の数値
        /// </summary>
        public int X;
        /// <summary>
        /// 二つ目の数値
        /// </summary>
        public int Y;
        /// <summary>
        /// MyStruct型の2数を初期化するコンストラクタ
        /// </summary>
        /// <param name="vx">一つ目に設定する数値</param>
        /// <param name="vy">二つ目に設定する数値</param>
        public MyStruct(int vx, int vy) {
            this.X = vx;
            this.Y = vy;
        }
    }
}
