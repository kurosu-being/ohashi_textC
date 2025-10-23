
namespace Practice1_2 {
    /// <summary>
    /// MyClass型の2数を保持するクラス
    /// </summary>
    class MyClass {
        /// <summary>
        /// 一つ目の数値
        /// </summary>
        public int X;
        /// <summary>
        /// 二つ目の数値
        /// </summary>
        public int Y;
        /// <summary>
        /// MyClass型の2数を初期化するコンストラクタ
        /// </summary>
        /// <param name="vx">一つ目に設定する数値</param>
        /// <param name="vy">二つ目に設定する数値</param>
        public MyClass(int vx, int vy) {
            this.X = vx;
            this.Y = vy;
        }
    }
}
