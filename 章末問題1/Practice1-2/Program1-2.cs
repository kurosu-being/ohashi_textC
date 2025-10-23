using System;

// 問題 1.2

// １．MyclassとMyStructの２つの型を引数にとるメソッドPrintObjectsを定義してください。
//     PrintObjectsメソッドでは、２つのオブジェクトの内容（プロパティの値）をコンソールに表示するようにしてください。
//     なお、PrintObjectsメソッドは、Programクラスのメソッドとして定義してください。

// ２．MainメソッドでPrintObjectsメソッドを呼び出すコードを書いてください。
//     Myclass、MyStructオブジェクトの値は、自由に決めてかまいません。

// ３．PrintObjectsメソッド内で、それぞれのプロパティの値を２倍に変更するコードを追加してください。
//     MainメソッドではPrintObjects呼び出しの後に、Myclass、MyStructオブジェクトのプロパティの値をコンソールに表示するコードを加えてください。

// ４．上のコードを実行し、結果を確認してください。そして、どうしてそのような結果になったのか、理由を説明してください。

// 4の解答
// classは参照型であり、structは値型であるためです。
// PrintObjectsメソッドにMyClassオブジェクトを渡すと、その参照が渡されるため、メソッド内でプロパティの値を変更すると、元のオブジェクトにも影響します。
// 一方、MyStructオブジェクトを渡すと、そのコピーが渡されるため、メソッド内でプロパティの値を変更しても、元のオブジェクトには影響しません。
// そのため、MainメソッドでMyClassのプロパティは2倍に変更されますが、MyStructのプロパティは元のままになります。

namespace Practice1_2 {
    internal class Program {
        /// <summary>
        ///  Myclass、MyStructのインスタンスを生成し、PrintObjectsメソッドを呼び出す
        ///  その後、2倍後の各プロパティの値をコンソールに表示する
        /// </summary>
        static void Main(string[] args) {
            // 2の解答
            MyClass wMyClass = new MyClass(10, 20);
            MyStruct wMyStruct = new MyStruct(30, 40);
            PrintObjects(wMyClass, wMyStruct);
            // 3の解答
            Console.WriteLine($"MyClass の X は { wMyClass.X } , Y は { wMyClass.Y } ２倍になっている！");
            Console.WriteLine($"MyStructの X は { wMyStruct.X } , Y は { wMyStruct.Y } 変化していない！");
        }
        // 1の解答
        /// <summary>
        /// vMyClassとvMyStructの内容をコンソールに表示し、それぞれのプロパティの値を２倍する
        /// </summary>
        /// <param name="vMyClass">MyClass型の2数</param>
        /// <param name="vMyStruct">MyStruct型の2数</param>
        static void PrintObjects(MyClass vMyClass, MyStruct vMyStruct) {
            Console.WriteLine($"MyClass の X は {vMyClass.X} , Y は {vMyClass.Y} ２倍になっている！");
            Console.WriteLine($"MyStructの X は {vMyStruct.X} , Y は {vMyStruct.Y} 変化していない！");
            // 3の解答
            vMyClass.X *= 2;
            vMyClass.Y *= 2;
            vMyStruct.X *= 2;
            vMyStruct.Y *= 2;
        }
    }
}
