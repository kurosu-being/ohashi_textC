// 問題 1.1

// 1. どら焼きオブジェクトを作成するコードを書いてください。
//    この時の商品番号は"98"、商品価格は"210円"としてください。

// 2. どら焼きオブジェクトの消費税額を計算し、コンソールに出力するコードを書いてください。

// 3. Productクラスにが属する名前空間を別の名前空間に変更し、Mainメソッドから呼び出すようにしてください。
//    ただし、MainメソッドのあるProgramクラスの名前空間はそのままとしてください。
using System;
using ProductNamespace;

namespace Practice1_1 {
    internal class Program {
        static void Main(string[] args) {
            // 1の解答
            var wProduct = new Product(98, "どら焼き", 210);
            // 2の解答
            Console.WriteLine($"どら焼きの消費税額は、{wProduct.GetTax()}円です");
        }
    }
}
