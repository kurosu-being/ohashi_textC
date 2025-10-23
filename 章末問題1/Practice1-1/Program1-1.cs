using ProductNamespace;
using System;

// 問題 1.1

// １．どら焼きオブジェクトを作成するコードを書いてください。
//     この時の商品番号は"98"、商品価格は"210円"としてください。

// ２．どら焼きオブジェクトの消費税額を計算し、コンソールに出力するコードを書いてください。

// ３． Pruductクラスにが属する名前空間を別の名前空間に変更し、Mainメソッドから呼び出すようにしてください。
//     ただし、MainメソッドのあるProgramクラスの名前空間はそのままとしてください。

namespace Practice1_1 {
    /// <summary>
    ///  Mainメソッドを実行するクラス
    /// </summary>
    internal class Program {
        /// <summary>
        /// どら焼きオブジェクトを作成し、消費税額を計算してコンソールに出力する
        /// </summary>
        static void Main(string[] args) {
            // 1の解答
            Product wProduct = new Product(98, "どら焼き", 210);
            // 2の解答
            Console.WriteLine($"どら焼きの消費税額は、{wProduct.GetTax()}円です");
        }
    }
}
